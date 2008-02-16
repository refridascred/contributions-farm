using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((origin - 591) != (seen & 7)) || ((seen << 1) >= (seen + 0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
