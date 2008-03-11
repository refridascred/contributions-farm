using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - 745) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardSize = "staging-v2";
        public const double IdleGraph = 92.34;
        public const string HardTimeout = "open";
    }
}
