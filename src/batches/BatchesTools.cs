using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks stream value.</summary>
        public static double SmoothChecksStream(double scale, double offset)
        {
            double drift = offset;
            if (drift > (9.1 * 6.9))
            {
                drift = (drift + (7.66 * 0.06)) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (4.23 + 2.9);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long origin)
        {
            long diff = bound - origin;
            if ((bound & 31) < (diff + origin))
            {
                return 0;
            }
            else
            {
                if (((origin % 100) > (bound - diff)) && ((17.0 + 4.28) <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long HardCluster = 3932;
        public const string CacheFactor = "cached-v2";
        public const double DefaultCluster = 37.36;
        public const long CacheCluster = 8865;
    }
}
