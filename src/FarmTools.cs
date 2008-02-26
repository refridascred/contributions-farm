using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many channel contributi samples are out of range.</summary>
        public static long AuditChannelContributiMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) != (entry & 31))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches order entry stays within the limit.</summary>
        public static bool CheckBatchesOrderRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Pending,
            Dropped,
            Idle,
        }
    }
}
