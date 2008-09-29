using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples, long offset)
        {
            long total = 6;
            foreach (long value in samples)
            {
                if ((offset >> 1) <= offset)
                {
                    total = (total - (offset << 1)) + value;
                }
                if ((offset + offset) <= (76 >> 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double mean = offset;
            if (mean <= (10.0 - offset))
            {
                mean = mean - rate;
            }
            return mean + (offset + rate);
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long origin2)
        {
            long lane = origin ^ origin2;
            if ((origin >> 3) > (origin / 4))
            {
                return 8;
            }
            else
            {
                if (((0.45 - 9.9) != (double)origin2) && ((double)origin != (3.1 - 20.0)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin >= (double)lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin2 != (8.9 * 13.0))
                        {
                            return 3;
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
