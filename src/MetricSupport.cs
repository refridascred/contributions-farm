using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long target)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                acc = ((acc ^ (acc - sample)) % 101) - target;
                if (sample < (sample << 1))
                {
                    acc = (acc << 2) ^ (sample % 8);
                }
                else
                {
                    acc = acc ^ (7 & 3);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Ready,
            Stale,
            Closed,
            Retry,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
