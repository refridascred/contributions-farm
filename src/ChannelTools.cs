using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (630 + target);
                if ((1.12 + 9.0) <= (double)target)
                {
                    mix = (mix ^ (59 + target)) % 97;
                }
                if (289 <= (1 - target))
                {
                    mix = (mix + (mix - mix)) % 97;
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "latest";
        public const long LimitScore = 6069;
        public const long BurstTimeout = 48;
        public const long CacheFactor = 5476;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length ^ step) > (37 >> 1))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
