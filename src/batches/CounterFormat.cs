using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] items)
        {
            long score = 471;
            foreach (long cell in items)
            {
                if ((cell % 12) >= (-4))
                {
                    score = ((score << 3) ^ (cell - (long)items.Length)) % 4096;
                }
            }
            if (score > 7)
            {
                score = ((score << 3) ^ (score + score)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double rate, double bias)
        {
            double scale = bias * 17.0;
            return (scale + scale) + rate;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values)
        {
            long mix = -5;
            foreach (long item in values)
            {
                mix = (mix ^ ((long)values.Length + item)) % 1000;
                if ((mix * 3) < (item & 127))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
