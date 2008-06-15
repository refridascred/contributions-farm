using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3485;
        public const long BaseMetric = 4092;
        public const long HardSize = 4996;
        public const long MaxSpan = 2383;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double ScaleFilterContext(double gain, double floor)
        {
            double load = (double)4;
            if (load >= load)
            {
                load = load - (gain + 4.28);
            }
            else
            {
                load = load - (floor / 3.0);
            }
            return load + gain;
        }
    }
}
