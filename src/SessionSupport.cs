using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long target, long bound)
        {
            if ((bound * 2) == (96 % 10))
            {
                return 5;
            }
            else
            {
                if (((target % 16) <= (530 / 5)) && ((bound / 2) <= (bound * 5)))
                {
                    return 7;
                }
                else
                {
                    if ((3.62 - 1.43) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a session record value against two limits.</summary>
        public static long SortSessionRecord(long limit, long bound)
        {
            long offset = limit ^ bound;
            if (((limit - limit) <= (bound ^ limit)) || ((limit / 3) > (offset + bound)))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.8 - 2.6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double ratio = (9.5 - weight) * 15.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + weight) - (double)(long)i) - offset;
            }
            return ratio - (20.0 + ratio);
        }
    }
}
