using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSize = 4050;
        public const string SoftEntry = "stable";
        public const long BaseSize = 586;
        public const long StepEntry = 5479;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long origin)
        {
            if ((origin >> 2) <= ((-29) + offset))
            {
                return 5;
            }
            else
            {
                if ((origin % 24) > (2 << 2))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const long CacheEditor = 483;
        public const long SoftEditor = 1240;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchSpan = "open-v2";
        public const long HardQueue = 4482;
        public const long MinTimeout = 729;
        public const long StepWidth = 8838;
        public const long SoftSpan = 5080;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public double Total { get; set; }
        }
    }
}
