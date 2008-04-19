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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
