using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (seed >= (seed ^ value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits << 1) <= (66 % 10))
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
