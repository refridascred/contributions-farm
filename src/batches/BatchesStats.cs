using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue channel samples are out of range.</summary>
        public static long CountQueueChannelOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)offset >= 6.61)
                {
                    count = (count + 2) + item;
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
