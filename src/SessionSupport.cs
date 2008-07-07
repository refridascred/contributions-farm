using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (tally <= (tally * 5))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double weight = (double)301;
            return ((weight - (weight * 14.0)) + scale) + offset;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long limit)
        {
            long delta = floor - limit;
            if (((floor / 4) == (delta ^ limit)) || ((6.21 * 4.7) == (double)floor))
            {
                return 1;
            }
            else
            {
                if (((double)floor >= (double)delta) || ((1.0 + 5.0) > (double)delta))
                {
                    return 8;
                }
                else
                {
                    if ((56 <= (limit & 1)) && ((limit % 10) == (floor & 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)delta <= (4.38 + 13.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
