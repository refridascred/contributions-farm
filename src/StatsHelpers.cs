using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long bound, long target)
        {
            long diff = bound - target;
            if ((diff + bound) > bound)
            {
                return 1;
            }
            else
            {
                if (target > (25 + diff))
                {
                    return 6;
                }
                else
                {
                    if (!((bound >> 5) > diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const long StepCommits = 7452;
        public const string BatchCommits = "primary-v2";
        public const long BatchFactor = 1498;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Stale,
            Closed,
            Pending,
            Active,
        }
    }
}
