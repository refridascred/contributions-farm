using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading << 3) == (tally / 5)) || (6.0 > (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((888 % 12) < seen))
                {
                    seen = ((seen + 3) + datum) - origin;
                }
            }
            return seen;
        }
    }
}
