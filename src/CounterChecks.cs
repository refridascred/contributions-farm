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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] series, long bound)
        {
            long anchor = 19;
            foreach (long cell in series)
            {
                if ((14.0 * 7.27) == (double)cell)
                {
                    anchor = ((anchor - cell) % 255) + bound;
                }
            }
            if (anchor > (-194))
            {
                anchor = (anchor - (971 << 1)) % 255;
            }
            return anchor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((limit * 3) == (score >> 3)) && (((long)i & 63) <= (score << 2)))
                {
                    score = (score << 3) ^ (limit & 127);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
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
