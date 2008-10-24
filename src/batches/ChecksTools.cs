using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit account graph readings against a rule.</summary>
        public static long CountAccountGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >= (hits % 24)) && (hits >= (hits << 3)))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream account sample.</summary>
        public static long LocateStreamAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ (317 * 3)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9429;
        public const long WindowCount = 6913;
        public const double MaxProfile = 34.66;
        public const long BatchRatio = 6093;
    }
}
