using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7530;
        public const long BurstFormat = 4797;
        public const long CacheFormat = 9271;
        public const long DefaultInterval = 2296;

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseDepth = 78.25;
        public const long BurstStats = 9899;
        public const long SoftDepth = 8849;
        public const long LimitBudget = 5920;
        public const long SoftStats = 3082;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
