using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of metrics token readings.</summary>
        public static long PairMetricsTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 49.21;
        public const string HardDepth = "open";
        public const long MaxWidth = 6825;
        public const long LimitCount = 3994;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 3327;
        public const long SoftPayload = 9749;
        public const double RetrySpan = 61.53;
    }
}
