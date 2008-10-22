using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultFactor = 53.22;
        public const double BurstSpan = 65.89;
        public const string BurstMetrics = "local-v2";

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double bias = (double)((-482) ^ 560);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long ClassifyContextSession(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((origin < floor) || (floor <= (lane ^ lane)))
            {
                return 2;
            }
            else
            {
                if (!((floor ^ origin) < (39 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
