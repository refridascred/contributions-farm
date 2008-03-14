using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of batch context readings.</summary>
        public static long PairBatchContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster graph entries that pass the check.</summary>
        public static long TallyClusterGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen != (5.0 * 6.5))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Synced,
            New,
            Retry,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long seed)
        {
            if ((17.0 + 4.0) < (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((7.9 - 3.0) == (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step != (0.31 + 3.16)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
