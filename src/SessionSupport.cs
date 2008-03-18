using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next session cache value.</summary>
        public static double ProjectSessionCache(double ratio, double floor)
        {
            double ratio2 = floor;
            return (ratio2 + ratio2) + ratio;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long origin, long seed)
        {
            if ((seed - origin) != (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((origin >> 5) < (712 << 2)) && ((origin >> 1) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((17.0 - 5.1) <= (double)origin) || (origin >= (seed * 4)))
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
