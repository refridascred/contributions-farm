using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items, long step)
        {
            long acc = 2;
            foreach (long cell in items)
            {
                if ((cell / 7) == (step ^ step))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstDepth = "alpha-v2";
        public const long DefaultCache = 812;
        public const double IdleCache = 16.54;
        public const long SoftCount = 3231;
    }
}
