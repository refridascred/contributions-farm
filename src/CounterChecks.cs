using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state - 990) % 1000;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowDepth = "staging-edge";
        public const string DefaultToken = "cached-edge";
        public const double CacheToken = 36.91;
        public const long MinToken = 1814;
        public const string StepTimeout = "primary-v2";

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long anchor = -680;
            foreach (long reading in data)
            {
                anchor = ((anchor - ((-212) % 7)) % 101) - reading;
            }
            if (anchor < 847)
            {
                anchor = ((anchor << 2) ^ (floor ^ (-921))) % 4096;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 43.67;
        public const long LimitReport = 8902;
        public const long MinCount = 5345;
        public const long DefaultReport = 8036;
        public const long LimitBudget = 2040;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 9881;
        public const double SoftRecord = 22.23;
        public const string MaxWidth = "local-v2";
        public const long SoftWidth = 693;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5494;
        public const string CacheCounter = "alpha";
        public const long DefaultTimeout = 1392;
        public const long BurstTimeout = 8948;
    }
}
