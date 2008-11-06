using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryLevel = 3.49;
        public const double LimitBudget = 54.46;
        public const long BaseContext = 285;
        public const long BatchRatio = 3766;
        public const long BatchContext = 5049;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseRatio = 3631;
        public const long MinFarm = 4316;
        public const long MaxRatio = 7301;
        public const long BatchFarm = 3223;
    }
}
