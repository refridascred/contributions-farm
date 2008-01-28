using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 1485;
        public const long LimitWidth = 851;
        public const long BurstStats = 2323;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 91.94;
        public const long MinScore = 4479;
        public const double BatchWidth = 82.76;
        public const long StepRatio = 9952;
        public const long CacheBudget = 3581;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
