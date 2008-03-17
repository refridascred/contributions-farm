using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long floor)
        {
            long delta = target ^ floor;
            if ((double)target <= (3.0 - 1.0))
            {
                return 0;
            }
            else
            {
                if (!((delta - 905) < ((-5) << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((target + floor) != (floor << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta > (1.0 - 6.7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (8 >= (limit & 7))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
