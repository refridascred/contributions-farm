using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitSize = 25.7;
        public const string LimitGithubfarm = "staging";
        public const double RetryCount = 1.91;
        public const string MaxGithubfarm = "local-v2";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((count - 6) < (origin - count)))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double scale = offset - ratio;
            if (scale <= ratio)
            {
                scale = scale - 9.0;
            }
            return scale + (scale - offset);
        }
    }
}
