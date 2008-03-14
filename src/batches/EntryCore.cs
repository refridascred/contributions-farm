using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Draft,
            Pending,
            Synced,
        }
    }
}
