/**
 * Autogenerated by Thrift Compiler (1.0.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Evernote.EDAM.NoteStore
{

  /// <summary>
  /// A structure containing the results of a call to createOrUpdateNotebookShares.
  /// 
  /// <dl>
  ///   <dt>updateSequenceNum</dt>
  ///   <dd>The USN of the notebook after the call.</dd>
  /// 
  ///   <dt>matchingShares</dt>
  ///   <dd>A list of SharedNotebook records that match the desired recipients. These
  ///       records may have been either created or updated by the call to
  ///       createOrUpdateNotebookShares, or they may have been at the desired privilege
  ///       privilege level prior to the call.</dd>
  /// </dl>
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CreateOrUpdateNotebookSharesResult : TBase
  {
    private int _updateSequenceNum;
    private List<Evernote.EDAM.Type.SharedNotebook> _matchingShares;

    public int UpdateSequenceNum
    {
      get
      {
        return _updateSequenceNum;
      }
      set
      {
        __isset.updateSequenceNum = true;
        this._updateSequenceNum = value;
      }
    }

    public List<Evernote.EDAM.Type.SharedNotebook> MatchingShares
    {
      get
      {
        return _matchingShares;
      }
      set
      {
        __isset.matchingShares = true;
        this._matchingShares = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool updateSequenceNum;
      public bool matchingShares;
    }

    public CreateOrUpdateNotebookSharesResult() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32) {
                UpdateSequenceNum = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  MatchingShares = new List<Evernote.EDAM.Type.SharedNotebook>();
                  TList _list158 = iprot.ReadListBegin();
                  for( int _i159 = 0; _i159 < _list158.Count; ++_i159)
                  {
                    Evernote.EDAM.Type.SharedNotebook _elem160;
                    _elem160 = new Evernote.EDAM.Type.SharedNotebook();
                    _elem160.Read(iprot);
                    MatchingShares.Add(_elem160);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("CreateOrUpdateNotebookSharesResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.updateSequenceNum) {
          field.Name = "updateSequenceNum";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(UpdateSequenceNum);
          oprot.WriteFieldEnd();
        }
        if (MatchingShares != null && __isset.matchingShares) {
          field.Name = "matchingShares";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, MatchingShares.Count));
            foreach (Evernote.EDAM.Type.SharedNotebook _iter161 in MatchingShares)
            {
              _iter161.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("CreateOrUpdateNotebookSharesResult(");
      bool __first = true;
      if (__isset.updateSequenceNum) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UpdateSequenceNum: ");
        __sb.Append(UpdateSequenceNum);
      }
      if (MatchingShares != null && __isset.matchingShares) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MatchingShares: ");
        __sb.Append(MatchingShares);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
