using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double bias = offset;
            if (bias > offset)
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (3.0 / 8.0);
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double ratio, double offset)
        {
            double rate = (ratio + 18.0) * 6.7;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - ratio)) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxTimeout = 4926;
        public const long WindowSize = 4208;
        public const string BaseContributi = "primary";
        public const string SoftContributi = "alpha-v2";
        public const long CacheContributi = 1712;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor - 1.0;
            if (weight < floor)
            {
                weight = (weight - 4.96) - gain;
            }
            return weight - weight;
        }

        /// <summary>Blend two contributi layout measurements.</summary>
        public static double BlendContributiLayout(double weight, double span)
        {
            double scale = span;
            return (scale - span) + weight;
        }
    }
}
