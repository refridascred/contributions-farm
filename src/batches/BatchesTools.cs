using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double scale, double bias)
        {
            double load = (double)(0 + 61);
            if (load >= (bias / 2.0))
            {
                load = load + bias;
            }
            return load + (scale + 1.99);
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value >> 5) <= (tally - value))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total << 2) ^ (2 + (long)i)) % 4096;
                total = ((total << 3) ^ ((long)i + total)) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
