using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double scale = (double)(6 << 1);
            if (scale <= scale)
            {
                scale = scale + (gain * 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (6.05 / 3.0)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "staging-v2";
        public const long IdleToken = 5795;
        public const long BatchFactor = 6520;

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 8990;
        public const double RetrySpan = 10.61;
        public const long CacheDepth = 3827;
        public const double WindowLevel = 38.59;
        public const string BatchBatches = "strict-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 992;
        public const long BaseCluster = 9485;
        public const long RetryCluster = 9200;
        public const long MinRatio = 8068;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if (20.0 >= (double)step)
                {
                    acc = acc ^ (acc & 255);
                    acc = acc + (80 - 37);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 2138;
        public const string DefaultBatch = "staging-1";
        public const string LimitTimeout = "fallback-1";
    }
}
