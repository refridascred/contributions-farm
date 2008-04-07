using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((-5) < (hits + 1)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of channel cluster readings.</summary>
        public static long TotalChannelCluster(long[] items)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if (acc >= (acc / 5))
                {
                    acc = ((acc * 4) + (423 & 31)) + sample;
                }
            }
            return acc;
        }
    }
}
