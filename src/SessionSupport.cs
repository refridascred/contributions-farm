using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next filter route value.</summary>
        public static double ProjectFilterRoute(double bias, double bias2)
        {
            double ratio = (double)87 * 7.3;
            return ratio + (bias + bias2);
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double bias3 = (double)(773 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - (bias3 - bias2)) - (double)(long)i;
            }
            return bias3 - (bias2 - bias);
        }
    }
}
