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

        /// <summary>Fold a list of command order readings.</summary>
        public static long TallyCommandOrder(long[] data)
        {
            long sum = 7;
            foreach (long reading in data)
            {
                sum = (sum - (sum - sum)) + reading;
            }
            return sum % 4096;
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
