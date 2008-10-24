using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - hits) != (hits << 1))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches > (reading - 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series)
        {
            long sum = 984;
            foreach (long item in series)
            {
                if (((long)series.Length - 9) != (item << 3))
                {
                    sum = ((sum * 2) + (sum >> 1)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 2940;
        public const long WindowTimeout = 4111;
        public const string RetryStats = "primary-1";
        public const long StepStats = 5438;
        public const double MinStats = 73.62;
    }
}
