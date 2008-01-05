using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Ready,
            Locked,
            Active,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 726;
        public const string LimitToken = "latest-edge";
        public const long RetrySize = 605;

        /// <summary>Measure how many channel batch samples are out of range.</summary>
        public static long AuditChannelBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((((matches - matches) < (cell >> 2)) && (cell < matches)) || ((1.7 * 1.62) > (double)cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
