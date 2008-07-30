using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long BucketOrderSchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (!((double)step < (double)31))
            {
                return 6;
            }
            else
            {
                if ((882 >> 3) >= step)
                {
                    return 7;
                }
                else
                {
                    if (step < (76 % 97))
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

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long bound2)
        {
            if ((bound2 + bound) >= (5 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound2 >= bound) || ((-948) >= bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound * 4) > (bound << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4.3 - 3.0) > (double)bound) || ((bound * 2) < 657))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double load = gain;
            if (load >= span)
            {
                load = load + (gain + span);
            }
            return load + (4.45 * 6.56);
        }
    }
}
