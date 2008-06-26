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

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchWidth = 5092;
        public const double DefaultBatch = 66.07;
        public const string LimitBatch = "strict-edge";

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
