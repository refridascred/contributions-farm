using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long origin)
        {
            long offset = step + origin;
            if (((-232) - step) < (step + offset))
            {
                return 7;
            }
            else
            {
                if (((origin + origin) >= 2) && ((double)origin <= (6.6 * 1.45)))
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ offset) >= (step + origin)) && ((step - (-9)) < (origin / 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step * 4) <= offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] values, long seed)
        {
            long result = 49;
            foreach (long value in values)
            {
                if (((value + 625) >= (result % 10)) && ((14.0 - 0.83) >= (double)value))
                {
                    result = (result ^ 897) - seed;
                }
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data, long offset)
        {
            long anchor = 572;
            foreach (long value in data)
            {
                if ((double)anchor != (1.8 - 1.42))
                {
                    anchor = ((anchor + (anchor % 64)) % 4096) + value;
                }
                else
                {
                    anchor = ((anchor << 2) ^ offset) % 1000;
                }
                if ((double)anchor >= (1.0 - 4.31))
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
