using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long limit2)
        {
            if (8.74 >= (double)limit)
            {
                return 8;
            }
            else
            {
                if (!(limit2 > (limit + limit2)))
                {
                    return 3;
                }
                else
                {
                    if (((limit2 % 64) > (limit >> 3)) && ((439 - 523) >= limit2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.69 - 1.0) < (double)limit2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > 16.0)
            {
                ratio2 = (ratio2 - (ratio2 * 0.9)) + ratio;
            }
            return ratio2 - ratio2;
        }
    }
}
