using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long target, long seed)
        {
            if ((double)target > 4.96)
            {
                return 0;
            }
            else
            {
                if (target > (seed - target))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a order filter reading.</summary>
        public static double AdjustOrderFilter(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + offset;
            }
            return rate - (double)22;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long acc = 3;
            foreach (long entry in series)
            {
                acc = (acc * 4) + (entry - entry);
            }
            if (acc > 90)
            {
                acc = ((acc << 2) ^ 12) % 1000;
            }
            return acc;
        }
    }
}
