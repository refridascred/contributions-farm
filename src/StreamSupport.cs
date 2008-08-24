using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double bias = offset;
            if (bias >= (offset + weight))
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long SeekCounterMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long score = 91;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (item / 4)) % 1000;
            }
            return score % 1000;
        }
    }
}
