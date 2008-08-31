using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of tools window readings.</summary>
        public static long PairToolsWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long offset)
        {
            long mix = 750;
            foreach (long cell in items)
            {
                mix = (mix << 2) ^ (cell + (long)items.Length);
                mix = (mix - cell) % 97;
            }
            if (mix < 66)
            {
                mix = ((mix * 4) + (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long seed)
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
