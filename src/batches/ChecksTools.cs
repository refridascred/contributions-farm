using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first editor batch entry that matches the target.</summary>
        public static long FindEditorBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftContributi = 25.33;
        public const long WindowContributi = 7457;
        public const long RetrySpan = 6261;
        public const string IdleContributi = "standard-edge";
        public const long MaxContributi = 9126;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
