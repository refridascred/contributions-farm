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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + limit) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
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
