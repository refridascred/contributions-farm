using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 1357;
        public const long LimitBudget = 1808;
        public const long RetryInterval = 5047;
        public const string LimitStats = "standard-edge";
        public const long MinStats = 2571;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes metrics readings against a rule.</summary>
        public static long TallyNotesMetricsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally >= (4.0 * 5.77))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (603 <= matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
