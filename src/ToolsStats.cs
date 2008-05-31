using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxMetric = 5211;
        public const long StepTimeout = 5560;
        public const string BatchRatio = "fallback";
        public const long DefaultMetric = 5108;
        public const long LimitRatio = 7498;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double scale = (double)(-15) - bias;
            if (scale <= floor)
            {
                scale = scale + (double)131;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 9.0)) - (double)(long)i;
            }
            return scale - (bias - bias);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 6364;
        public const long MinAlready = 3463;
        public const long LimitAlready = 6137;
        public const string CacheLevel = "fallback";
        public const long HardCount = 4248;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            New,
            Active,
            Synced,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Ready,
            Synced,
        }
    }
}
