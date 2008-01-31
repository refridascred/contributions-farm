using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long offset)
        {
            if ((double)offset != (2.5 + 4.72))
            {
                return 5;
            }
            else
            {
                if (target < offset)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 - scale2) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha-v2";
        public const long MaxBuffer = 6268;
        public const double RetryTimeout = 98.93;
        public const double StepDepth = 80.72;
        public const double BurstBuffer = 23.82;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
