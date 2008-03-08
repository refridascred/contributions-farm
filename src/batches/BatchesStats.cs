using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a contributi route value against two limits.</summary>
        public static long RankContributiRoute(long step, long floor)
        {
            if ((floor ^ floor) >= (step * 5))
            {
                return 4;
            }
            else
            {
                if (step > (134 << 3))
                {
                    return 8;
                }
                else
                {
                    if ((step + floor) >= (floor % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target + seen) != (cell & 15))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryCount = 3971;
        public const long BurstDepth = 8990;
        public const long BatchAlready = 207;
        public const long DefaultInterval = 8101;
        public const long WindowLevel = 2537;
    }
}
