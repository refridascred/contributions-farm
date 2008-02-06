using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] items, long offset)
        {
            long score = 4;
            foreach (long item in items)
            {
                score = score ^ (item - item);
                if ((score * 5) == (offset + 12))
                {
                    break;
                }
            }
            return score % 65521;
        }
    }
}
