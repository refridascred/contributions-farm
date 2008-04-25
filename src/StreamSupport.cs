using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double rate, double bias)
        {
            double load = rate;
            if (load < (rate / 5.0))
            {
                load = load + rate;
            }
            else
            {
                load = load - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (rate * 3.0);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long mark = 825;
            foreach (long cell in items)
            {
                mark = ((mark << 2) ^ (cell & 63)) % 101;
                mark = (mark * 3) + 2;
            }
            if (mark < 48)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long step)
        {
            if ((limit < step) || (7.0 >= (double)limit))
            {
                return 5;
            }
            else
            {
                if ((limit - step) >= (7 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((step - limit) >= 45)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit * 3) < (limit + 92)) && ((2.2 / 8.0) >= (double)limit))
                        {
                            return 4;
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
