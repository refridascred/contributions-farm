using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "alpha";
        public const long LimitBatches = 7937;
        public const long StepRatio = 1619;
        public const double BaseBatches = 70.5;
        public const long BatchBatches = 6787;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
