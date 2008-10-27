using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (!((tally << 2) != (reading - reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 4678;
        public const string DefaultBatches = "legacy-edge";
        public const long MinLevel = 5451;
        public const string DefaultInterval = "staging";
    }
}
