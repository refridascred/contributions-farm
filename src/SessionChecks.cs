using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank counter buffer input into a small class.</summary>
        public static long BucketCounterBuffer(long bound, long floor)
        {
            if ((977 / 8) >= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor == (3.6 + 0.3))
                {
                    return 5;
                }
                else
                {
                    if ((0.79 >= (0.6 / 7.0)) && ((53 / 8) >= bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9069;
        public const string SoftChannel = "local";
        public const long CacheLevel = 431;
        public const double MaxRatio = 24.01;
        public const long RetryChannel = 2403;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
