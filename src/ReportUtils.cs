using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item < (hits / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double scale2 = floor - floor;
            if (scale2 > scale)
            {
                scale2 = scale2 + (double)12;
            }
            return scale2 - (scale * 9.5);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (18 % 24))
                {
                    seen = ((seen + 2) - value) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long seed, long bound)
        {
            long offset = seed - bound;
            if (((bound + offset) > (offset ^ offset)) && ((double)bound != (0.13 + 14.0)))
            {
                return 7;
            }
            else
            {
                if (((offset - bound) >= (seed / 7)) || ((offset + bound) == (bound * 3)))
                {
                    return 2;
                }
                else
                {
                    if (seed >= (38 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
