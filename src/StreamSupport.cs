using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = 62;
            foreach (long value in samples)
            {
                if ((2.5 - 0.22) <= (double)value)
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < (-8))
            {
                mix = ((mix << 3) ^ ((long)samples.Length >> 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long bound)
        {
            if ((offset - 72) < (7 / 3))
            {
                return 7;
            }
            else
            {
                if ((offset / 7) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound > (double)7)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound == (double)82)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
