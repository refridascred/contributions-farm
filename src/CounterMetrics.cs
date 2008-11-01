using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 609;
        public const long MinWidth = 8151;
        public const long HardRatio = 7988;
        public const long MaxWidth = 1419;
        public const long DefaultTimeout = 464;

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double span)
        {
            double drift = ratio;
            if (drift <= ratio)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (span / 9.0);
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
