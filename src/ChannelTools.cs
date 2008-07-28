using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values)
        {
            long anchor = -521;
            foreach (long entry in values)
            {
                anchor = anchor + (anchor + entry);
                if (!(entry < (entry % 2)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2929;
        public const long LimitCount = 4185;
        public const string BaseDepth = "latest-1";
        public const long BatchWindow = 5970;
        public const double BurstFactor = 84.1;
    }
}
