using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window already entries that pass the check.</summary>
        public static long AuditWindowAlreadyMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((7.4 - 14.0) == (double)count)
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double bias, double bias2)
        {
            double scale = bias2;
            return scale - bias;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (496 < floor)
            {
                return 8;
            }
            else
            {
                if ((limit - floor) < (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((884 & 7) == (floor + 625))
                    {
                        return 0;
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
