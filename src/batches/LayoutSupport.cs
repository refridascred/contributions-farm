using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Retry,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long origin)
        {
            long mix = 8;
            foreach (long item in items)
            {
                mix = (mix + item) % 65521;
                if (origin <= ((long)items.Length ^ item))
                {
                    mix = ((mix << 3) ^ (item % 10)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool GuardTokenCacheBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
