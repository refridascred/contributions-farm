using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long bound)
        {
            if ((seed + 15) != (bound + seed))
            {
                return 6;
            }
            else
            {
                if ((bound * 5) > seed)
                {
                    return 8;
                }
                else
                {
                    if ((36 << 1) < (seed << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + seed) < (bound + 95))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double bias = 8.6;
            if (bias > (double)32)
            {
                bias = (bias + 7.0) + scale;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (16.0 + span);
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
