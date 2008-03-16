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

        /// <summary>Combine notes command values into a single score.</summary>
        public static long FoldNotesCommand(long[] data, long step)
        {
            long result = -59;
            foreach (long datum in data)
            {
                if (21 >= datum)
                {
                    result = ((result << 2) ^ 2) - step;
                }
            }
            return result % 1000;
        }
    }
}
