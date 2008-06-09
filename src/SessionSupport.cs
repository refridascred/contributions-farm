using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Active,
            Closed,
            Failed,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 5980;
        public const long HardRatio = 3367;
        public const string StepTimeout = "fallback-v2";
        public const string BurstOrder = "staging";
        public const long MaxScore = 4962;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 5980;
        public const string LimitSize = "alpha-edge";
        public const double MaxTimeout = 47.47;
    }
}
