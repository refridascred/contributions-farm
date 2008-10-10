using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double rate, double span)
        {
            double weight = rate;
            if (weight > (rate * 0.34))
            {
                weight = (weight - weight) - span;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)4) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long RankCacheTools(long floor, long limit)
        {
            if (limit < (floor / 8))
            {
                return 7;
            }
            else
            {
                if (!((limit / 7) != (limit / 3)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series)
        {
            long mix = 438;
            foreach (long item in series)
            {
                if ((mix % 2) != (28 / 3))
                {
                    mix = (mix - (item - mix)) % 101;
                }
            }
            if (mix < 9)
            {
                mix = mix - (mix << 3);
            }
            return mix % 65521;
        }
    }
}
