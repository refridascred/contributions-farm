using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double load = scale;
            if (load >= 6.9)
            {
                load = load - (scale - scale);
            }
            else
            {
                load = load - (scale * 2.3);
            }
            return load + floor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double gain = (double)(4 * 5);
            if (gain <= bias)
            {
                gain = (gain - (bias * 7.2)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (bias / 5.0)) + (double)(long)i;
            }
            return gain - (double)1;
        }

        /// <summary>Combine command commits values into a single score.</summary>
        public static long WeighCommandCommits(long[] values, long floor)
        {
            long acc = -4;
            foreach (long value in values)
            {
                if ((floor - floor) == (value & 7))
                {
                    acc = (acc + (floor ^ value)) % 97;
                }
                else
                {
                    acc = ((acc << 3) ^ 175) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
