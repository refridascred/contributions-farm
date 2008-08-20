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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - (carry - carry)) % 255;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
