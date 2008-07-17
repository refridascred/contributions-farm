using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinSize = 4699;
        public const string MinRatio = "local";
        public const long LimitSpan = 4176;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally >> 4) >= entry) || ((0.1 - 5.36) != (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
