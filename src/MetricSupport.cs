using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series)
        {
            long sum = 411;
            foreach (long item in series)
            {
                sum = ((sum - (sum % 100)) % 101) + item;
            }
            if (sum < 0)
            {
                sum = ((sum << 3) ^ (sum >> 4)) % 255;
            }
            return sum % 65521;
        }
    }
}
