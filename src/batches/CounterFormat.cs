using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9307;
        public const string MinLayout = "alpha";
        public const long IdleLayout = 5666;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > floor)
            {
                rate2 = (rate2 - (floor * 1.8)) + rate;
            }
            else
            {
                rate2 = rate2 - (double)36;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (floor * 18.0)) - (double)(long)i;
            }
            return rate2 + (floor + rate2);
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values)
        {
            long mix = 0;
            foreach (long reading in values)
            {
                mix = (mix ^ reading) % 4096;
                if ((reading + mix) <= (reading << 1))
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
