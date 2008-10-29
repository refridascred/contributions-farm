using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchFactor = 5422;
        public const string CacheBatch = "alpha-edge";
        public const string SoftBatch = "staging-v2";

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Locate a entry support reading by value.</summary>
        public static long LocateEntrySupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
