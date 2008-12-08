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

        /// <summary>Blend two record entry measurements.</summary>
        public static double ScaleRecordEntry(double bias, double span)
        {
            double bias2 = span;
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - span;
        }
    }
}
