using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix + (bound >> 3)) + (long)i2;
                }
                if (!((mix / 9) >= mix))
                {
                    mix = mix ^ (99 << 3);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] levels, long offset)
        {
            long sum = -7;
            foreach (long item in levels)
            {
                if ((sum ^ item) <= item)
                {
                    sum = ((sum << 3) ^ ((-49) * 5)) % 255;
                }
                sum = sum - (item / 7);
            }
            if (sum < 40)
            {
                sum = (sum << 3) ^ offset;
            }
            return sum % 1000;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if ((2.15 + 1.2) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if (((7.0 + 2.0) > (double)bound) || ((bound + bound) == (bound % 7)))
                {
                    return 5;
                }
                else
                {
                    if (bound < 351)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
