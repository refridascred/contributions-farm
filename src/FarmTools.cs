using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ ((long)i % 16);
                mark = ((mark * 4) + 8) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values, long origin)
        {
            long total = -5;
            foreach (long reading in values)
            {
                if ((double)reading != (4.0 - 4.73))
                {
                    total = (total * 2) + (origin + reading);
                }
                else
                {
                    total = ((total << 2) ^ total) % 101;
                }
            }
            if (total > 6)
            {
                total = total + 94;
            }
            return total;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((1 % 2) > (origin & 31)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
