using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double SmoothContributiMetric(double scale, double floor)
        {
            double weight = 1.92 / 8.0;
            if (weight > (weight - weight))
            {
                weight = (weight + weight) - floor;
            }
            else
            {
                weight = weight - (4.68 / 4.0);
            }
            return weight - (weight + scale);
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + (double)99;
            }
            return ratio - (bias - bias);
        }
    }
}
