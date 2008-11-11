using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long AuditFarmEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + floor) >= 32)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long limit, long floor)
        {
            long gap = limit - floor;
            if ((gap > (floor & 7)) && ((gap ^ floor) >= (limit + floor)))
            {
                return 8;
            }
            else
            {
                if ((gap < (gap >> 5)) && (floor > (gap + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((gap + gap) <= (limit >> 5))
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

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= (double)1)
            {
                ratio2 = ratio2 - (ratio * 18.0);
            }
            return ratio2 - ratio2;
        }
    }
}
