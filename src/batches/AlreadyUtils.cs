using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double mean = weight;
            if (mean >= (floor / 6.0))
            {
                mean = mean + 9.52;
            }
            return mean + (double)866;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long seed, long seed2)
        {
            if (seed2 >= seed)
            {
                return 6;
            }
            else
            {
                if ((seed2 & 15) > seed2)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
