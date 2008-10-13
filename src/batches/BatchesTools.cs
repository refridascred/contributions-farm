using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter cache samples.</summary>
        public static long CombineFilterCache(long[] values)
        {
            long sum = -60;
            foreach (long datum in values)
            {
                sum = (sum ^ (datum + sum)) % 255;
                if (!((long)values.Length >= (199 >> 5)))
                {
                    break;
                }
            }
            if (sum > (-74))
            {
                sum = (sum + ((-6) + sum)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 73.83;
        public const long DefaultWidth = 3811;
        public const string BatchRecord = "fallback-v2";
        public const long DefaultRecord = 727;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
