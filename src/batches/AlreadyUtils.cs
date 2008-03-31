using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                if (entry <= (entry + acc))
                {
                    acc = ((acc << 3) ^ entry) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = (acc << 3) ^ (acc % 60);
            }
            return acc;
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
