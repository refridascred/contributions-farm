using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long SeekCommitsSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits >= (5.07 * 1.73))
                {
                    hits = ((hits + 1) - cell) - offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry % 97) < 8)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 599;
        public const double RetryContext = 7.71;
        public const long HardInterval = 2796;
        public const long RetryLevel = 6597;
    }
}
