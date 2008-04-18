using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 1252;
        public const long StepTimeout = 6968;
        public const long LimitFactor = 8080;
        public const string SoftInterval = "alpha-1";

        /// <summary>Combine cache stream values into a single score.</summary>
        public static long ScoreCacheStream(long[] data)
        {
            long sum = 777;
            foreach (long entry in data)
            {
                sum = ((sum + sum) % 101) + entry;
            }
            if (sum < 42)
            {
                sum = sum ^ (sum / 3);
            }
            return sum;
        }
    }
}
