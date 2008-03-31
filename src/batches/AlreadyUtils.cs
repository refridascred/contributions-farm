using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long total = -403;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (total - 866)) % 97) + reading;
            }
            return total % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long state = 58;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (state ^ state)) ^ sample;
            }
            if (state < 0)
            {
                state = ((state * 4) + (8 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Done,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
