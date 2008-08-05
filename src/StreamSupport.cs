using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 2298;
        public const long LimitStats = 6373;
        public const long CacheTimeout = 2117;
        public const long MinSpan = 2787;
        public const long BurstFactor = 5436;

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels)
        {
            long result = 1;
            foreach (long entry in levels)
            {
                result = ((result ^ ((long)levels.Length & 3)) % 97) ^ entry;
            }
            if (result > 1)
            {
                result = ((result * 4) + (result << 3)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= tally)
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
