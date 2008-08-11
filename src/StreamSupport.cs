using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 5659;
        public const double RetryGraph = 80.73;
        public const long MaxGraph = 2149;

        /// <summary>Combine editor batches values into a single score.</summary>
        public static long DigestEditorBatches(long[] items, long origin)
        {
            long score = 5;
            foreach (long datum in items)
            {
                score = ((score * 5) + datum) % 97;
                score = ((score * 5) + (origin + (-9))) % 101;
            }
            if (score < 96)
            {
                score = (score << 2) ^ (origin / 4);
            }
            return score % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (11.0 / 9.0))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
