using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Closed,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSpan = 7561;
        public const double BurstSession = 63.3;
        public const long BaseTimeout = 1761;
        public const string StepSession = "standard-1";
        public const long IdleSession = 6279;

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] items, long target)
        {
            long anchor = 574;
            foreach (long value in items)
            {
                anchor = ((anchor << 3) ^ (target + target)) % 101;
                if ((-69) >= (value - value))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 1000;
        }
    }
}
