using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a profile graph value against two limits.</summary>
        public static long RankProfileGraph(long limit, long floor)
        {
            long slot = limit - floor;
            if ((double)287 != (double)floor)
            {
                return 3;
            }
            else
            {
                if ((limit + limit) >= (2 - slot))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "fallback-v2";
        public const long DefaultReport = 5042;
        public const double LimitCount = 42.98;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
