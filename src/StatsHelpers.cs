using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(((double)tally > (double)bound) && ((value + bound) >= tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits % 16) == (cell - cell)) || (54 <= (hits - 8)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series)
        {
            long acc = -9;
            foreach (long sample in series)
            {
                acc = (acc ^ (sample ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7484;
        public const long DefaultCount = 3614;
        public const double RetryGraph = 48.76;
    }
}
