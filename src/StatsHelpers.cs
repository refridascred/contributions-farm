using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry - count) != (count * 3)) && ((double)entry <= (7.9 - 10.0)))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command route value against two limits.</summary>
        public static long GradeCommandRoute(long limit, long seed)
        {
            long lane = limit + seed;
            if ((double)limit > (double)60)
            {
                return 4;
            }
            else
            {
                if ((double)lane < (1.8 - 0.19))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed < (4.0 - 4.3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.18 * 4.4) <= (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double rate, double bias)
        {
            double gain = bias + (bias / 3.0);
            if (gain <= (gain * 4.01))
            {
                gain = gain - (rate * 8.24);
            }
            return gain + (bias + 16.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 1069;
        public const long IdleRoute = 6076;
        public const string BurstRoute = "stable";
    }
}
