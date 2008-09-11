using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a notes profile pair into a bucket.</summary>
        public static long SortNotesProfile(long origin, long seed)
        {
            long prev = origin - seed;
            if ((seed > (seed % 100)) || ((prev << 2) == (7 * 5)))
            {
                return 3;
            }
            else
            {
                if (((prev - prev) < prev) && ((57 + seed) > 31))
                {
                    return 8;
                }
                else
                {
                    if ((0 >> 5) <= (prev % 24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 1248;
        public const double MaxCount = 23.36;
        public const long HardLevel = 5580;

        /// <summary>Iterate the stats checks series from a seed.</summary>
        public static long StepStatsChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
