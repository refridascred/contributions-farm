using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long RollSessionSchema(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double rate, double bias)
        {
            double ratio = (3.26 / 8.0) + (double)6;
            if (ratio > (bias / 4.0))
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio - rate)) + (double)(long)i;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + mix) < mix)
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long bound)
        {
            long next = origin + bound;
            if (!((bound / 3) < (0 + bound)))
            {
                return 1;
            }
            else
            {
                if (next >= (next >> 5))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin > (3.33 * 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound <= (origin / 6)) && (84 <= (origin & 255)))
                        {
                            return 8;
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
