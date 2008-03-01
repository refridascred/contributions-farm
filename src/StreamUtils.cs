using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 47.44;
        public const long BurstFactor = 7239;
        public const string IdleWidth = "standard";

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches - matches) >= (121 + matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Stale,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 521;
        public const long WindowCount = 6478;
        public const long BatchContributi = 5201;
    }
}
