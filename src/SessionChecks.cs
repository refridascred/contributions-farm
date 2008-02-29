using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                carry = carry + datum;
            }
            return carry % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 9804;
        public const string RetryDepth = "strict";
        public const double MinTimeout = 90.39;
        public const long CacheStats = 8174;
        public const long HardStats = 9230;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 255;
                if ((double)entry != (8.6 + 2.0))
                {
                    mix = mix - (mix + entry);
                }
                else
                {
                    mix = ((mix << 2) ^ (182 + mix)) % 65521;
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix << 2)) % 255;
            }
            return mix;
        }
    }
}
