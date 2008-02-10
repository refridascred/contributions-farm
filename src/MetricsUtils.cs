using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (17.0 >= (double)(long)series.Length)
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Stale,
            Closed,
            Failed,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryCount = 86.28;
        public const double BatchGithubfarm = 78.08;
        public const long CacheGithubfarm = 8424;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 5872;
        public const string MaxTimeout = "staging";
        public const long LimitContext = 8728;
        public const double IdleBudget = 66.84;
    }
}
