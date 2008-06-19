using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long seed)
        {
            if (!((target * 4) != (439 % 2)))
            {
                return 6;
            }
            else
            {
                if (target <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((18.0 + 8.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed / 6) <= (target - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a graph commits counter forward.</summary>
        public static long RollGraphCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ ((long)i + 64)) % 65521;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
