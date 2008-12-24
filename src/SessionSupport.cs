using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                acc = (acc ^ acc) - value;
            }
            return acc;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long bound)
        {
            long edge = step ^ bound;
            if ((950 - edge) <= (step + edge))
            {
                return 0;
            }
            else
            {
                if ((bound + step) > edge)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double mean = (double)850 + 6.0;
            if (mean > bias)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (rate * 1.2);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
