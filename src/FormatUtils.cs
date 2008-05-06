using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] levels, long floor)
        {
            long state = 633;
            foreach (long item in levels)
            {
                state = ((state - ((-94) + item)) % 97) - floor;
            }
            return state;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double bias = floor * 2.29;
            if (bias <= (double)735)
            {
                bias = bias - (bias / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (ratio - ratio);
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "cached-1";
        public const long LimitWindow = 5413;
        public const string RetryCount = "local-1";
        public const long CacheCount = 5006;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
