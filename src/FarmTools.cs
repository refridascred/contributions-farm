using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if ((seed & 127) == (seed + bound2))
            {
                return 6;
            }
            else
            {
                if ((bound2 ^ 934) >= (seed ^ bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)1 > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + bound2) == (seed ^ seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long AuditCounterContributiOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((38 % 5) > (seen & 255)) && ((datum >> 2) != (datum & 255))) && !((double)datum >= (5.0 + 1.2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values, long seed)
        {
            long mix = -8;
            foreach (long cell in values)
            {
                if (!((double)mix < (19.0 * 9.0)))
                {
                    mix = (((mix << 3) ^ (mix + cell)) % 65521) - seed;
                }
            }
            return mix;
        }
    }
}
