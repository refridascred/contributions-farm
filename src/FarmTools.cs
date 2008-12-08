using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((268 / 6) < offset))
                {
                    sum = (sum + (sum & 255)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)value < 2.9)
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double load = (double)2;
            if (load >= (double)7)
            {
                load = (load - (double)509) - gain;
            }
            else
            {
                load = load + 7.25;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias / 8.0)) + (double)(long)i;
            }
            return load + (double)276;
        }
    }
}
