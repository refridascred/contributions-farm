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

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardCount = 3649;
        public const double DefaultBudget = 53.7;
        public const string WindowSize = "primary-v2";
        public const string BurstStream = "latest";

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
