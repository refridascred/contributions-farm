using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "staging-edge";
        public const long IdleQueue = 4684;
        public const long BurstSpan = 4977;

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLevel = 51.75;
        public const double LimitBudget = 50.61;
        public const long BurstRatio = 8555;
        public const string HardLayout = "alpha-edge";
    }
}
