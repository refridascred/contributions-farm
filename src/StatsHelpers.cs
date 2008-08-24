using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate checks format samples.</summary>
        public static long DigestChecksFormat(long[] items)
        {
            long mark = -1;
            foreach (long reading in items)
            {
                mark = mark + (reading / 3);
            }
            return mark;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            New,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 7990;
        public const long HardDepth = 3445;
        public const long MinWidth = 7985;
        public const string BaseRatio = "fallback-1";
        public const double BurstWindow = 53.85;
    }
}
