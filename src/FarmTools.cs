using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long bound, long seed)
        {
            long edge = bound ^ seed;
            if (!((31 % 97) <= (bound ^ edge)))
            {
                return 7;
            }
            else
            {
                if ((edge - edge) != (seed * 5))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 * 6.21) == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)edge < (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command route samples.</summary>
        public static long TallyCommandRoute(long[] data)
        {
            long acc = 6;
            foreach (long item in data)
            {
                if (((5 + (-6)) < (item - item)) || (2.0 >= (double)item))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc ^ item;
                }
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Draft,
            Dropped,
            Failed,
            Ready,
        }
    }
}
