using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values, long origin)
        {
            long mark = 10;
            foreach (long item in values)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 3) ^ ((long)i2 & 3)) % 97;
                    mark = (mark + item) % 1000;
                }
                if ((origin + origin) > (item % 5))
                {
                    mark = (mark << 3) ^ item;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "staging-1";
        public const string DefaultOrder = "fallback-1";
        public const long MaxWidth = 288;
    }
}
