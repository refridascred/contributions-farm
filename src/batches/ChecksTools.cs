using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first account support entry that matches the target.</summary>
        public static long FindAccountSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry stats readings against a rule.</summary>
        public static long TallyEntryStatsOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally >> 5) == (tally / 8))
                {
                    tally = ((tally + 2) ^ entry) + step;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 3584;
        public const string IdleLevel = "latest";
        public const string SoftCommand = "cached-1";

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long target, long seed)
        {
            if (seed > target)
            {
                return 5;
            }
            else
            {
                if (seed <= target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
