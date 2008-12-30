using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardLevel = 9198;
        public const string StepRatio = "local-edge";
        public const long WindowFormat = 3447;
        public const long BatchLevel = 9565;

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 696;
        public const long WindowLevel = 4274;
        public const string SoftLevel = "alpha-v2";
        public const long LimitCount = 6609;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Ready,
            Active,
        }
    }
}
