using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] samples, long target)
        {
            long sum = 592;
            foreach (long datum in samples)
            {
                if (((datum << 2) < (sum * 5)) && (target >= (target % 2)))
                {
                    sum = ((sum * 2) + 24) % 65521;
                }
                if ((datum * 3) >= (-166))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
