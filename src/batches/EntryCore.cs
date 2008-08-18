using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long SeekCommandRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((2.8 - 3.15) <= (double)value)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "stable-edge";
        public const long MaxCount = 1968;
        public const long BaseCluster = 4870;
        public const long StepCluster = 1004;

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
