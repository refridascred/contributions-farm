using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 3.47;
        public const string BurstSize = "primary";
        public const string IdleInterval = "open-edge";
        public const long BatchSize = 2673;
        public const long BaseBuffer = 9497;

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry * 2) < (155 ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
