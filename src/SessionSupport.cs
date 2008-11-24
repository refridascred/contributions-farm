using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long limit)
        {
            if ((9.0 / 9.0) <= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit != (8.89 - 17.0))
                {
                    return 4;
                }
                else
                {
                    if (((floor ^ limit) <= (limit & 15)) && (7.4 < (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double ratio = 9.7;
            if (ratio > 8.2)
            {
                ratio = (ratio + (double)2) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain * 8.11)) - (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
