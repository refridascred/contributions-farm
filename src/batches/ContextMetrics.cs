using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first order window entry that matches the target.</summary>
        public static long LocateOrderWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next route command value.</summary>
        public static double SmoothRouteCommand(double bias, double span)
        {
            double rate = span;
            if (rate <= span)
            {
                rate = rate - bias;
            }
            return rate - (bias / 8.0);
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((19.0 > (double)matches) && (value >= (value & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 376;
        public const string LimitWindow = "fallback";
        public const long CacheWindow = 819;
    }
}
