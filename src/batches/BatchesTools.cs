using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if (((double)state >= (16.0 - 2.0)) || ((floor * 4) <= (long)i))
                {
                    state = state + floor;
                }
                else
                {
                    long lane = (state * 3) << 2;
                    state = state ^ lane;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Adjust a already batch reading.</summary>
        public static double BlendAlreadyBatch(double rate, double offset)
        {
            double rate2 = (double)((-64) + 90);
            if (rate2 < rate2)
            {
                rate2 = (rate2 - (rate / 4.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (double)(-733)) - (double)(long)i;
            }
            return rate2 + (rate - rate2);
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long offset)
        {
            long gap = limit - offset;
            if (!((offset & 7) <= (offset * 5)))
            {
                return 1;
            }
            else
            {
                if (72 < (gap % 97))
                {
                    return 5;
                }
                else
                {
                    if ((double)gap > (double)6)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)gap <= 10.0)
                        {
                            return 0;
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
}
