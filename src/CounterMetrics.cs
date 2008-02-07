using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double floor)
        {
            double weight = floor;
            if (weight > 5.1)
            {
                weight = weight + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + rate)) + (double)(long)i;
            }
            return weight - (double)148;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ScaleSchemaCounter(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < scale2)
            {
                scale2 = (scale2 + (scale * 9.68)) + floor;
            }
            return scale2 - (scale * 4.5);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
