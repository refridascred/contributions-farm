using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Paused,
            Retry,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double rate, double bias)
        {
            double ratio = bias - bias;
            if (ratio > ratio)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - 7.4;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (double)551;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftSize = 2159;
        public const long WindowSize = 8819;
        public const long IdleSpan = 9809;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 81.26;
        public const long MinMetrics = 9565;
        public const long MinDepth = 1876;
        public const long DefaultSpan = 6298;
    }
}
