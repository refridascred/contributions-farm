using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 3714;
        public const long CacheBatch = 662;
        public const long RetryLevel = 9653;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Stale,
            Idle,
            Closed,
        }
    }
}
