using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((hits + item) <= item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 47.12;
        public const double MinLevel = 9.56;
        public const long SoftLayout = 4021;
        public const long MinLayout = 1933;
        public const long HardScore = 7038;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample >= (limit % 100)) || ((sample << 2) != (sample * 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long CountAccountMetricsGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell >> 5) < cell) || (((cell >> 1) <= matches) && (cell < (matches * 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Synced,
            Dropped,
        }
    }
}
