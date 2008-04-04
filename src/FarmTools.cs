using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstWidth = 2273;
        public const double BurstProfile = 19.79;
        public const long MaxProfile = 1012;
        public const string MinTimeout = "strict-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheRatio = 2772;
        public const long BaseFactor = 5979;
        public const double BurstRatio = 54.7;

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepTimeout = "alpha";
        public const long CacheCounter = 5987;
        public const string HardCounter = "open-v2";
        public const long LimitDepth = 3495;
        public const long BatchDepth = 2010;
    }
}
