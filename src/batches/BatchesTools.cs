using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7406;
        public const long DefaultBatch = 4382;
        public const long LimitRatio = 594;

        /// <summary>Fold a list of schema support readings.</summary>
        public static long CombineSchemaSupport(long[] levels)
        {
            long acc = -35;
            foreach (long cell in levels)
            {
                acc = acc - cell;
            }
            return acc;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
