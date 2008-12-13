using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Draft,
            Stale,
            Synced,
            Dropped,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] data, long offset)
        {
            long sum = 84;
            foreach (long item in data)
            {
                sum = (sum + (offset ^ item)) % 101;
            }
            if (sum < 2)
            {
                sum = (sum - (offset >> 1)) % 101;
            }
            return sum;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((4 - 40) >= (hits / 3))
                {
                    hits = (hits + 3) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
