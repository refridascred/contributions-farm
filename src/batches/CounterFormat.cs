using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long bound)
        {
            if (!((bound << 3) >= origin))
            {
                return 4;
            }
            else
            {
                if (bound <= ((-639) % 60))
                {
                    return 1;
                }
                else
                {
                    if (!((origin & 15) == (9 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((13.0 + 6.59) <= (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally != (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double ratio, double offset)
        {
            double bias = (double)55;
            return ((bias - (double)31) + ratio) + offset;
        }
    }
}
