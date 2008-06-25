using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long floor)
        {
            if ((double)floor != (8.5 * 2.0))
            {
                return 8;
            }
            else
            {
                if (floor < (seed - floor))
                {
                    return 6;
                }
                else
                {
                    if ((seed / 6) == (seed + 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double scale = (double)(296 >> 2);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale - (9.97 / 3.0)) + (double)(long)i) - ratio) - floor;
            }
            return scale - (double)33;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "local-v2";
        public const long BatchTimeout = 1355;
        public const double IdleQueue = 19.32;

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long TallySupportBatchesMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((5 >> 5) >= seen)
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitSize = 73.99;
        public const long HardDepth = 7270;
        public const long StepTimeout = 675;
        public const long BurstDepth = 8825;
    }
}
