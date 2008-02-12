using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up order route samples.</summary>
        public static long PairOrderRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftDepth = 4498;
        public const long RetryTimeout = 8944;
        public const double RetryFactor = 47.82;
    }
}
