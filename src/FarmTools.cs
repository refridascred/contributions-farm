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

        /// <summary>Derive the next command report value from a seed.</summary>
        public static long DeriveCommandReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                if (((1.0 - 7.7) > (double)step) || ((sum & 31) > step))
                {
                    sum = (sum * 5) + (sum * 2);
                }
                sum = (sum << 2) ^ (step * 4);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
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
