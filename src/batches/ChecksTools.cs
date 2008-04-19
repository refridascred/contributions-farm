using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long origin, long seed)
        {
            long next = origin ^ seed;
            if ((next <= (next - origin)) || ((9 / 8) > (next - seed)))
            {
                return 8;
            }
            else
            {
                if ((seed - origin) != (93 * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (9.0 + 7.86))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.76 / 5.0) <= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double gain, double floor)
        {
            double gain2 = floor;
            return (gain2 - floor) + gain;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((3.3 * 0.9) > (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
