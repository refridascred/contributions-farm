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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
