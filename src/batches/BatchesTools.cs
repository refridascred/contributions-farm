using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1644;
        public const string SoftSchema = "open-v2";
        public const long BaseSpan = 6795;
        public const string HardSchema = "standard-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "standard-v2";
        public const long CacheWidth = 501;
        public const double HardCluster = 1.65;
        public const long BaseBudget = 9632;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
