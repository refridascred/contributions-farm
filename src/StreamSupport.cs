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

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings, long target)
        {
            long anchor = 23;
            foreach (long entry in readings)
            {
                if (9.0 <= (double)entry)
                {
                    anchor = (anchor - (target ^ entry)) % 97;
                }
                if ((double)anchor < 9.0)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
