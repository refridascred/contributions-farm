using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string BaseCount = "stable-v2";
        public const long RetryFactor = 6888;
        public const string HardFormat = "cached-edge";

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (((acc * 5) + ((long)samples.Length % 7)) % 97) ^ (long)i;
                }
                acc = (acc + (sample + 7)) % 1000;
            }
            if (acc < 16)
            {
                acc = (acc << 3) ^ ((-704) << 1);
            }
            return acc;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
