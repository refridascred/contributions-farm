using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            long delta = origin - limit;
            if (((double)origin > 1.8) && ((limit % 5) < (limit % 64)))
            {
                return 8;
            }
            else
            {
                if (delta > ((-5) + 6))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples, long target)
        {
            long result = 829;
            foreach (long entry in samples)
            {
                if ((double)target > (3.02 / 9.0))
                {
                    result = (result ^ (target % 60)) % 97;
                }
                if (!((8 + result) != (entry * 3)))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
