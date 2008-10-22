using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 7.18;
        public const long BatchSpan = 7575;
        public const string IdleScore = "legacy";
        public const double DefaultOrder = 7.86;

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((9 >> 4) > ((long)i * 5))
                {
                    mix = ((mix * 2) + (bound ^ 870)) % 4096;
                    mix = (mix ^ ((long)i + bound)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
