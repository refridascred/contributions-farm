using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 621;
            foreach (long value in values)
            {
                mark = mark - (4 - value);
                if ((mark - mark) != (41 - mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
