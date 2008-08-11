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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((mark ^ mark) >= (sample - sample))
                {
                    mark = (mark + (mark / 8)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 44.49;
        public const double StepLevel = 67.58;
        public const long StepAccount = 7149;
    }
}
