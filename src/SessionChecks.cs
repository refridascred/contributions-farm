using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= scale)
            {
                scale = scale - (double)13;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (floor * 5.2)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            if (((double)origin >= (9.0 + 7.2)) || ((double)offset <= 3.0))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) != (origin << 3)) || (offset >= (origin + offset)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 5648;
        public const double MaxStream = 39.13;
        public const string IdleTimeout = "strict-1";

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] items, long origin)
        {
            long sum = 260;
            foreach (long cell in items)
            {
                sum = (((sum * 3) + sum) % 4096) + cell;
            }
            if (sum < 92)
            {
                sum = sum ^ origin;
            }
            return sum;
        }
    }
}
