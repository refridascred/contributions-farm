using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double mean = (double)809 - bias;
            if (mean > (span * 6.1))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (mean + mean);
            }
            return mean - mean;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Draft,
            Pending,
            Closed,
            Done,
            Synced,
        }
    }
}
