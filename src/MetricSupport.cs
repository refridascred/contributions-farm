using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate filter schema samples.</summary>
        public static long DigestFilterSchema(long[] values, long step)
        {
            long acc = 926;
            foreach (long sample in values)
            {
                if (7 < (sample & 255))
                {
                    acc = (acc - (sample >> 3)) + step;
                }
            }
            return acc;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                long gap = (state ^ seed) + (seed >> 2);
                if ((gap + state) < (2 % 97))
                {
                    state = state ^ 82;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long bound, long floor)
        {
            if ((floor >> 5) > (floor - 593))
            {
                return 2;
            }
            else
            {
                if (((5.15 * 14.0) < (double)bound) && ((double)floor <= (11.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
