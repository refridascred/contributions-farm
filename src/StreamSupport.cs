using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 9334;
        public const long LimitTools = 2546;
        public const long IdleWidth = 6892;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                sum = sum - item;
            }
            if (sum > 27)
            {
                sum = (sum + sum) % 1000;
            }
            return sum;
        }
    }
}
