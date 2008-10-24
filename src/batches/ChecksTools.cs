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

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFactor = 34.32;
        public const string BatchFormat = "standard-1";
        public const long BaseWidth = 2880;
        public const long MinDepth = 6202;
    }
}
