using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((floor + (-9)) != (value << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 41.83;
        public const long DefaultChecks = 1720;
        public const long WindowChecks = 4170;
        public const double MaxChecks = 91.31;
    }
}
