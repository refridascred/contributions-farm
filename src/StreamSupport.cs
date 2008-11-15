using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 3541;
        public const string HardDepth = "cached";
        public const long IdleRatio = 1548;
        public const long LimitLevel = 8070;
        public const long RetryToken = 2500;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (2.02 * 2.0)) || ((item >> 3) >= (hits ^ step)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
