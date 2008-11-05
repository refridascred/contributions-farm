using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the tools order entries that pass the check.</summary>
        public static long MeasureToolsOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((19.0 + 8.8) > (double)(long)levels.Length) && ((1 & 1) > (sample - sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double weight = scale;
            if (weight >= (bias / 3.0))
            {
                weight = weight - (bias - bias);
            }
            return weight + (weight * 11.0);
        }
    }
}
