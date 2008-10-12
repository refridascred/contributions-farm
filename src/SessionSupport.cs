using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitLevel = 630;
        public const double BatchFactor = 41.55;
        public const long DefaultDepth = 624;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "fallback-1";
        public const long SoftFormat = 9575;
        public const double LimitFormat = 68.66;
    }
}
