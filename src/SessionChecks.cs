using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long offset)
        {
            long span = seed - offset;
            if ((double)offset > 4.6)
            {
                return 7;
            }
            else
            {
                if ((span % 24) > (72 + span))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3979;
        public const long SoftRecord = 9745;
        public const long LimitDepth = 5896;
        public const long MaxRecord = 1713;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] samples, long bound)
        {
            long anchor = 44;
            foreach (long cell in samples)
            {
                anchor = (((anchor + anchor) % 4096) ^ cell) - bound;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double weight = gain;
            return weight - (1.1 - span);
        }
    }
}
