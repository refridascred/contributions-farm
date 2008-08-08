using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1513;
        public const double IdleContributi = 76.71;
        public const long BatchSpan = 4700;
        public const long MaxRatio = 2050;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long mark = -8;
            foreach (long entry in series)
            {
                mark = (mark ^ (mark << 1)) ^ entry;
            }
            if (mark > 645)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
