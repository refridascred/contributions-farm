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

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double scale = ratio + floor;
            for (int i = 0; i < 4; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (floor + scale);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstTimeout = 78.44;
        public const double CacheRatio = 34.42;
        public const double LimitBuffer = 41.62;
    }
}
