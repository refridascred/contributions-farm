using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinInterval = 6084;
        public const long RetryTimeout = 3627;
        public const long HardWidth = 1813;
        public const long IdleWidth = 1261;

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long floor)
        {
            long sum = 171;
            foreach (long entry in readings)
            {
                if ((entry & 1) <= (81 & 63))
                {
                    sum = ((sum << 2) ^ (entry - 686)) % 65521;
                }
                else
                {
                    sum = (sum ^ (7 + floor)) % 1000;
                }
            }
            return sum;
        }
    }
}
