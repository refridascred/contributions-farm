using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long bound)
        {
            long bound2 = limit - bound;
            if (((bound2 >> 5) <= limit) || ((bound2 & 31) <= (64 - 37)))
            {
                return 1;
            }
            else
            {
                if ((double)bound2 <= (5.1 * 8.01))
                {
                    return 5;
                }
                else
                {
                    if (0 < (bound2 + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound <= (16 & 127)) && ((bound2 >> 4) == (bound2 + bound2)))
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

        /// <summary>Blend two account buffer measurements.</summary>
        public static double BlendAccountBuffer(double rate, double floor)
        {
            double ratio = (double)(7 + 0);
            if (ratio >= floor)
            {
                ratio = ratio + (double)22;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (floor - floor);
        }
    }
}
