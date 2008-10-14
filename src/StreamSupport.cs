using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long ClassifyRouteContext(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((origin * 4) > (edge + 315))
            {
                return 2;
            }
            else
            {
                if (((origin - limit) < (edge << 2)) && ((6.34 * 6.5) <= (double)edge))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            long cur = step - floor;
            if ((367 << 3) < (floor / 8))
            {
                return 1;
            }
            else
            {
                if ((double)cur >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (!((floor - floor) >= (-2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (floor & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
