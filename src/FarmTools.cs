using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long target)
        {
            long gap = floor - target;
            if ((floor ^ gap) <= (target + floor))
            {
                return 4;
            }
            else
            {
                if (gap > (223 % 16))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] data, long limit)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = (score + (limit / 5)) - reading;
            }
            if (score > (-68))
            {
                score = score + (69 << 1);
            }
            return score;
        }
    }
}
