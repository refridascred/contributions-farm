using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchRatio = 9463;
        public const long BaseDepth = 6631;
        public const long BurstInterval = 381;
        public const long DefaultDepth = 440;

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
