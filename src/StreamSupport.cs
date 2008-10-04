using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstFactor = "open-1";
        public const long BaseMetrics = 2205;
        public const double BurstMetrics = 4.56;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
