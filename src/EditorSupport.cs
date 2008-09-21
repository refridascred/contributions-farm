using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] series, long step)
        {
            long mark = 66;
            foreach (long reading in series)
            {
                if ((step + mark) <= step)
                {
                    mark = ((mark << 3) ^ (mark ^ step)) - reading;
                }
            }
            if (mark < 19)
            {
                mark = (mark ^ (step * 5)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 563;
        public const string BaseSession = "local-1";
        public const string BatchSession = "standard-v2";
        public const long HardCount = 1885;
        public const long LimitSession = 3795;

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values)
        {
            long mark = 307;
            foreach (long value in values)
            {
                mark = mark - value;
            }
            return mark % 65521;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel commits samples.</summary>
        public static long TotalChannelCommits(long[] levels)
        {
            long mix = 4;
            foreach (long item in levels)
            {
                mix = ((mix << 2) ^ mix) % 255;
                mix = ((mix * 3) + item) % 101;
                if ((mix < (mix - 423)) || ((item - item) >= (mix + item)))
                {
                    break;
                }
            }
            if (mix < 366)
            {
                mix = mix ^ (mix - 5);
            }
            return mix % 4096;
        }

        /// <summary>Roll a entry editor counter forward.</summary>
        public static long SeriesEntryEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (((total * 5) + 8) % 4096) ^ (long)i2;
                }
                total = total - (origin + total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
