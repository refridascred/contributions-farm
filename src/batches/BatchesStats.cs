using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long carry = 544;
            foreach (long cell in readings)
            {
                if ((carry / 4) <= cell)
                {
                    carry = (carry * 4) + (carry >> 5);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long target)
        {
            long mix = 13;
            foreach (long reading in readings)
            {
                mix = (((mix ^ 85) % 101) ^ reading) - target;
            }
            return mix % 65521;
        }

        /// <summary>Grade a stream route value against two limits.</summary>
        public static long GradeStreamRoute(long origin, long target)
        {
            long gap = origin - target;
            if (((gap * 3) > (target + gap)) && ((6.0 + 1.85) >= (double)target))
            {
                return 8;
            }
            else
            {
                if ((origin >= (target >> 1)) && (origin < ((-986) % 7)))
                {
                    return 4;
                }
                else
                {
                    if ((0.27 < (double)gap) && (origin < 61))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a context layout counter forward.</summary>
        public static long RollContextLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if (floor > (state ^ state))
                {
                    state = state - (floor << 1);
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
