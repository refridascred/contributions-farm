using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 872;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (322 >> 1)) + cell;
            }
            if (result < 90)
            {
                result = (result * 5) + (result ^ result);
            }
            return result;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "legacy-1";
        public const long SoftCount = 4787;
        public const long DefaultSize = 7376;
    }
}
