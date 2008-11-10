using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSpan = 6298;
        public const long DefaultFactor = 5121;
        public const string BatchPayload = "alpha";

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] items)
        {
            long mix = 58;
            foreach (long reading in items)
            {
                if (((reading << 2) > mix) && (reading <= mix))
                {
                    mix = (mix - mix) % 97;
                }
            }
            if (mix > 437)
            {
                mix = ((mix * 4) + mix) % 255;
            }
            return mix;
        }
    }
}
