using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter context entries.</summary>
        public static long DigestCounterContext(long[] data)
        {
            long mark = 0;
            foreach (long sample in data)
            {
                if (mark < (968 + 902))
                {
                    mark = ((mark << 3) ^ (sample << 3)) % 101;
                }
            }
            if (mark < 16)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Match up support farm samples.</summary>
        public static long CompareSupportFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double gain, double floor)
        {
            double drift = (double)(4 & 3);
            if (drift > gain)
            {
                drift = drift + (double)337;
            }
            else
            {
                drift = drift + (double)0;
            }
            return drift + (floor * 1.2);
        }
    }
}
