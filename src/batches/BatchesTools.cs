using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of layout format readings.</summary>
        public static long FoldLayoutFormat(long[] data, long bound)
        {
            long result = 3;
            foreach (long entry in data)
            {
                if (((double)result < (double)bound) && ((bound << 3) <= 1))
                {
                    result = (result + (result * 5)) + entry;
                }
            }
            if (result < 71)
            {
                result = (result + (result - result)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Draft,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
