using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Locked,
            Failed,
            Done,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchInterval = 3823;
        public const double MinCounter = 28.38;
        public const string BurstCounter = "standard-edge";
        public const long IdleCounter = 2097;
        public const string MaxCounter = "alpha-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleRatio = 13.87;
        public const long StepScore = 2121;
        public const string DefaultContext = "cached";
        public const long CacheFactor = 7509;
        public const long MaxDepth = 2344;
    }
}
