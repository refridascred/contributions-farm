using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate context already samples.</summary>
        public static long CombineContextAlready(long[] samples)
        {
            long state = 184;
            foreach (long entry in samples)
            {
                if (entry <= state)
                {
                    state = (state - (state + 966)) % 97;
                }
                else
                {
                    state = (state + (entry & 3)) % 65521;
                }
                if ((state - entry) < state)
                {
                    state = ((state * 2) + (state ^ entry)) % 97;
                }
                else
                {
                    state = ((state * 4) + (state + entry)) % 255;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long GradeMetricsFarm(long seed, long floor)
        {
            long diff = seed + floor;
            if (diff >= (222 % 5))
            {
                return 8;
            }
            else
            {
                if (((diff / 6) != (floor + 10)) || ((floor + seed) == (diff - 35)))
                {
                    return 7;
                }
                else
                {
                    if ((diff % 64) == (seed % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
