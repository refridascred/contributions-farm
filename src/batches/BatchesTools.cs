using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long target)
        {
            long slot = offset ^ target;
            if ((slot / 4) == (slot % 7))
            {
                return 4;
            }
            else
            {
                if ((target / 8) >= (offset % 8))
                {
                    return 2;
                }
                else
                {
                    if (20.0 < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)slot >= (10.0 * 1.69))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheDepth = "standard-1";
        public const string BaseFactor = "standard-edge";
        public const long MinMetric = 2296;
        public const double WindowMetric = 82.61;
        public const long LimitScore = 9179;

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
