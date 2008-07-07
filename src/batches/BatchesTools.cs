using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 3591;
        public const double BatchTimeout = 95.51;
        public const long LimitSchema = 8482;
        public const long WindowSchema = 781;
        public const long BurstSchema = 5784;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstSpan = "legacy-1";
        public const double DefaultBatches = 50.25;
        public const long BurstBatches = 7738;
        public const long WindowSpan = 3817;
        public const long CacheBatches = 5907;

        /// <summary>Grade a format graph value against two limits.</summary>
        public static long BucketFormatGraph(long floor, long limit)
        {
            if ((2.0 > (double)limit) || (limit > (735 - limit)))
            {
                return 3;
            }
            else
            {
                if (floor > (limit + 1))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
