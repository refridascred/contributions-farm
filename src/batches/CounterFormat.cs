using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank command counter input into a small class.</summary>
        public static long BucketCommandCounter(long bound, long offset)
        {
            long edge = bound + offset;
            if ((bound & 3) <= (offset / 8))
            {
                return 4;
            }
            else
            {
                if (!((edge + 4) <= 51))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound > (4.76 * 8.89)) || (6 <= (offset >> 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (total ^ (origin * 3)) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long DeriveStatsBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!!((2.83 / 4.0) > (double)(long)i))
                {
                    mix = (mix + 0) % 65521;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (((mix * 5) + (floor & 7)) % 65521) + (long)i2;
                    mix = mix ^ ((long)i * 4);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
