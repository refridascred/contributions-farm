using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series)
        {
            long score = 2;
            foreach (long item in series)
            {
                if ((4.5 - 6.1) <= (double)item)
                {
                    score = score + (item << 1);
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double load = bias * 4.6;
            for (int i = 0; i < 8; i++)
            {
                load = (load + (scale + load)) + (double)(long)i;
            }
            return load - 4.7;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry / 6) == (9 / 6)) || ((entry - count) == (entry + 61)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
