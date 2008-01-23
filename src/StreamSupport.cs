using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i % 64) > (offset << 3)) && ((offset / 9) >= offset))
                {
                    mix = mix - (offset ^ offset);
                    mix = (mix * 5) + offset;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchFactor = 5765;
        public const long BaseWidth = 1671;
        public const string LimitContributi = "fallback-edge";
        public const long HardWidth = 5825;

        /// <summary>Count contributi checks pairs that satisfy a relation.</summary>
        public static long CompareContributiChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
