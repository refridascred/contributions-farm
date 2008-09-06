using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values, long bound)
        {
            long acc = 23;
            foreach (long entry in values)
            {
                if (acc > 67)
                {
                    acc = ((acc ^ (entry + acc)) % 65521) - bound;
                }
            }
            if (acc < 9)
            {
                acc = (acc * 5) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long seed)
        {
            if (seed < (limit / 3))
            {
                return 0;
            }
            else
            {
                if ((6.38 + 4.98) == (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Locked,
            New,
            Closed,
        }

        /// <summary>Find the first batch support entry that matches the target.</summary>
        public static long LookupBatchSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Pending,
            Done,
            Queued,
            New,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
