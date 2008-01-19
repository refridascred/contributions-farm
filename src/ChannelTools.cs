using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 1903;
        public const double LimitBatches = 90.3;
        public const double DefaultBatches = 22.44;
        public const double IdleBatches = 21.82;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Paused,
            Done,
        }
    }
}
