using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double bias)
        {
            double weight = 10.0;
            if (weight > ratio)
            {
                weight = (weight - weight) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long target, long limit)
        {
            if ((double)limit < (5.68 / 8.0))
            {
                return 3;
            }
            else
            {
                if (target >= (limit << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next format metrics value from a seed.</summary>
        public static long StepFormatMetrics(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ (offset >> 3)) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
