using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 6313;
        public const long CacheSpan = 9221;
        public const double MinFactor = 59.27;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9004;
        public const long SoftFilter = 4966;
        public const double MinSpan = 1.04;
        public const double HardFilter = 27.34;
        public const long CacheRatio = 9060;
    }
}
