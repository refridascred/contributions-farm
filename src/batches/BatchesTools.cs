using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstWidth = 2280;
        public const double RetryMetrics = 10.28;
        public const long MaxRatio = 8343;
        public const long SoftFactor = 2298;
        public const long BaseScore = 5832;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
