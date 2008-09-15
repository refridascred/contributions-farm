using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 2010;
        public const long IdleChannel = 1123;
        public const long RetryChannel = 9751;
        public const long HardLevel = 4861;
        public const long DefaultDepth = 1378;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long seed)
        {
            long state = 9;
            foreach (long cell in series)
            {
                if ((559 >> 2) >= (cell * 3))
                {
                    state = ((state * 2) + state) % 65521;
                }
                else
                {
                    state = (state ^ seed) % 65521;
                }
            }
            if (state < 14)
            {
                state = ((state * 4) + seed) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)3)
            {
                rate = (rate + (double)67) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (3.7 - weight)) + (double)(long)i;
            }
            return rate + (double)82;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values, long limit)
        {
            long mix = 263;
            foreach (long value in values)
            {
                if (mix > (value / 5))
                {
                    mix = ((mix << 2) ^ (84 >> 2)) + limit;
                }
                else
                {
                    mix = mix - value;
                }
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long floor)
        {
            if (!((double)step >= (5.63 + 1.2)))
            {
                return 2;
            }
            else
            {
                if (step >= (step + step))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
