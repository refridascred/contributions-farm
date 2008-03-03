using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            New,
            Closed,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5543;
        public const long HardTimeout = 3593;
        public const long CacheMetric = 5694;
        public const double WindowMetric = 13.55;
        public const long WindowRatio = 1172;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((19.0 + 6.3) != (double)value)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Locate a channel cluster reading by value.</summary>
        public static long SeekChannelClusterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
