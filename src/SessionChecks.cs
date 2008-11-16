using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels, long offset)
        {
            long result = 425;
            foreach (long entry in levels)
            {
                if ((2.87 / 4.0) > (double)entry)
                {
                    result = (result + (result % 8)) % 65521;
                }
                if ((entry < (offset - result)) && ((3.41 + 16.0) <= (double)entry))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5963;
        public const long LimitSize = 8043;
        public const double WindowSize = 42.77;
        public const long MinDepth = 3615;

        /// <summary>Look up the position of a record batch sample.</summary>
        public static long SeekRecordBatchIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
