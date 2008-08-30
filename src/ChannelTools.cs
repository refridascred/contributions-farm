using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2821;
        public const long MaxChannel = 8903;
        public const long DefaultChannel = 1637;
        public const long SoftChannel = 426;

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowLevel = 50.5;
        public const double BurstReport = 97.3;
        public const long HardSize = 1099;
        public const long WindowReport = 4191;
        public const double MaxBudget = 45.84;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }
    }
}
