using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool GuardStatsMetricsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ value) <= (count * 5))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
