using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long ClassifyCacheContributi(long limit, long step)
        {
            if ((double)limit > (double)(-10))
            {
                return 0;
            }
            else
            {
                if ((step << 3) == (61 >> 2))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
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
