using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseTimeout = 7787;
        public const long BatchTimeout = 8113;
        public const double BatchCache = 7.76;
        public const long RetryCache = 6364;
        public const long IdleCache = 5456;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                sum = (sum ^ (reading & 127)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Closed,
            Failed,
            Queued,
        }
    }
}
