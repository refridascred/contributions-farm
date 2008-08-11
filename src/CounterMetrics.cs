using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long limit)
        {
            long diff = floor - limit;
            if ((limit + floor) <= (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((double)diff < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (!(floor <= (diff % 10)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double bias2)
        {
            double bias3 = bias2;
            for (int i = 0; i < 5; i++)
            {
                bias3 = ((bias3 + (bias3 + bias2)) + (double)(long)i) - bias;
            }
            return bias3 - (bias3 + 1.34);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long total = 8;
            foreach (long value in series)
            {
                if ((total - value) >= (260 + 61))
                {
                    total = total ^ (value / 6);
                }
                if (!((total - value) >= total))
                {
                    total = total + (value ^ value);
                }
            }
            if (total < 2)
            {
                total = ((total * 2) + total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 44.49;
        public const double StepLevel = 67.58;
        public const long StepAccount = 7149;
    }
}
