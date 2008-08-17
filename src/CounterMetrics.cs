using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3254;
        public const long BatchTimeout = 8278;
        public const long BurstRecord = 7587;
        public const long BaseRatio = 9429;
        public const double CacheSpan = 71.54;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Check that every batch stream entry stays within the limit.</summary>
        public static bool GuardBatchStreamRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
