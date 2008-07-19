using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long DeriveCacheContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = mix + (offset << 2);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long mark = -31;
            foreach (long value in items)
            {
                mark = ((mark * 3) + (floor - 9)) - value;
            }
            return mark % 1000;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long step2)
        {
            if ((8.56 - 16.0) >= (double)step2)
            {
                return 4;
            }
            else
            {
                if ((step / 8) == (step & 31))
                {
                    return 3;
                }
                else
                {
                    if (step2 <= (step2 + step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step2 + step2) > (step2 + 33)) || (step < (step - step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
