using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if ((mix ^ 136) >= (mix / 9))
                {
                    mix = (mix + (mix + mix)) % 1000;
                }
                mix = ((mix << 2) ^ step) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a stats graph pair into a bucket.</summary>
        public static long GradeStatsGraph(long seed, long target)
        {
            long prev = seed + target;
            if ((seed <= (178 >> 3)) || (prev > (target << 3)))
            {
                return 3;
            }
            else
            {
                if ((seed << 3) <= 31)
                {
                    return 7;
                }
                else
                {
                    if ((target + 889) > (target + seed))
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

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long target)
        {
            if (target >= 490)
            {
                return 6;
            }
            else
            {
                if (!((double)bound == (19.0 * 8.57)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
