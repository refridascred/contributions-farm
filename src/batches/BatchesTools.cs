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

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data, long seed)
        {
            long result = 82;
            foreach (long entry in data)
            {
                if (seed > (result >> 5))
                {
                    result = ((result ^ (result & 31)) % 65521) ^ entry;
                }
            }
            if (result < 71)
            {
                result = result - ((long)data.Length * 3);
            }
            return result;
        }

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
