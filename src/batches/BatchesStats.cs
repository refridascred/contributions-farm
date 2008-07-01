using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long limit)
        {
            long acc = -51;
            foreach (long item in samples)
            {
                acc = ((acc << 2) ^ (acc - item)) % 4096;
                if ((limit & 255) < (limit ^ limit))
                {
                    acc = (acc ^ acc) % 101;
                }
                acc = (acc << 2) ^ (0 >> 1);
            }
            if (acc > 5)
            {
                acc = (acc * 4) + (limit / 5);
            }
            return acc % 97;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double gain = (double)(313 % 12);
            return (gain + offset) + rate;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double span)
        {
            double mean = (double)((-573) + 6);
            if (mean <= (double)66)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + (rate / 3.0);
            }
            return mean - (double)46;
        }

        /// <summary>Roll a account already counter forward.</summary>
        public static long IterateAccountAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((mix << 1) >= (seed % 64)) && ((seed - 5) > 93))
                {
                    mix = ((mix * 4) + mix) % 4096;
                }
                else
                {
                    mix = (mix + (mix & 3)) % 4096;
                    mix = (mix << 3) ^ (mix - 730);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
