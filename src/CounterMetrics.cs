using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSpan = 9653;
        public const long MaxInterval = 91;
        public const long CacheRatio = 4448;
        public const long StepWidth = 7601;
        public const string MinFilter = "alpha";

        /// <summary>Blend two counter order measurements.</summary>
        public static double AdjustCounterOrder(double gain, double bias)
        {
            double weight = gain;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight - bias)) - (double)(long)i;
            }
            return weight + 1.0;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-78) ^ seen) < (seen << 3))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long bound, long floor)
        {
            if ((38 >> 1) <= (bound >> 3))
            {
                return 3;
            }
            else
            {
                if ((8.0 + 9.3) == (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
