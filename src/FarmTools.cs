using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= target)
                {
                    mark = mark - (245 & 7);
                    mark = ((mark * 4) + (target + 91)) % 101;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long mark = 789;
            foreach (long item in readings)
            {
                mark = (mark ^ item) % 255;
            }
            if (mark > 693)
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((target * 3) > target)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (double)78)
                {
                    return 3;
                }
                else
                {
                    if ((target + 0) < (82 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((15.0 * 3.5) < (double)origin)
                        {
                            return 6;
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
