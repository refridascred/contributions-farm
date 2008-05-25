using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinCount = 6749;
        public const long RetrySpan = 3328;
        public const long BatchDepth = 1892;
        public const long BaseDepth = 5513;
        public const long LimitTimeout = 3532;

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a channel metric figure with a bias.</summary>
        public static double ProjectChannelMetric(double ratio, double floor)
        {
            double weight = (ratio / 3.0) * 15.0;
            if (weight > (double)7)
            {
                weight = weight + 4.43;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 6.95) + (double)(long)i;
            }
            return weight - (16.0 + floor);
        }
    }
}
