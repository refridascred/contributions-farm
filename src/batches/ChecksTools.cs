using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowSpan = "legacy";
        public const long WindowGraph = 6042;
        public const long MinWidth = 1198;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] levels)
        {
            long mark = 5;
            foreach (long reading in levels)
            {
                if (((double)reading >= 2.2) && ((mark - reading) != (reading + reading)))
                {
                    mark = (mark - ((-633) * 4)) % 97;
                    mark = ((mark << 2) ^ reading) % 255;
                    continue;
                }
                if (((reading + 417) > (1 & 15)) || ((mark - reading) >= mark))
                {
                    mark = (mark - (reading - mark)) % 4096;
                }
                else
                {
                    mark = mark ^ (reading - 685);
                }
            }
            if (mark > 2)
            {
                mark = (mark * 2) + 412;
            }
            return mark;
        }
    }
}
