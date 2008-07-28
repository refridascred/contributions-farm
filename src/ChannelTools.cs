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

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultFactor = 4400;
        public const long RetryEditor = 8982;
        public const long BatchEditor = 9370;
    }
}
