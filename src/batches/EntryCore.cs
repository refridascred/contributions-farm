using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((double)offset != (16.0 - 3.9)) && (value <= (offset / 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long sum = -34;
            foreach (long value in data)
            {
                sum = sum + (value - 692);
            }
            if (sum > 4)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstTimeout = 78.44;
        public const double CacheRatio = 34.42;
        public const double LimitBuffer = 41.62;
    }
}
