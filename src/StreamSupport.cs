using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinScore = 10.23;
        public const long HardDepth = 6071;
        public const long BaseRatio = 2603;
        public const long CacheBudget = 716;
        public const long MinCache = 3173;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 1376;
        public const long HardSize = 244;
        public const string BurstQueue = "latest-1";
        public const double MinTimeout = 51.98;
        public const long DefaultRatio = 2996;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Pending,
            Active,
        }
    }
}
