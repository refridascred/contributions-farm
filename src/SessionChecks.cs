using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor + ((long)i ^ 6)) % 255;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 2) ^ (bound & 15)) % 97) - (long)i2;
                }
                anchor = anchor - (bound - (long)i);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up already filter samples.</summary>
        public static long MatchAlreadyFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double ProjectRouteEditor(double weight, double floor)
        {
            double mean = (double)(39 >> 1);
            if (mean < (weight - mean))
            {
                mean = (mean + weight) + floor;
            }
            else
            {
                mean = mean - (1.6 / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (weight * 7.8)) + (double)(long)i;
            }
            return mean - 12.0;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long seed, long bound)
        {
            long next = seed ^ bound;
            if (((next + 33) < (seed & 31)) && ((bound & 7) <= 9))
            {
                return 2;
            }
            else
            {
                if (next <= bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound + 996) >= (bound ^ next))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((4.0 + 9.6) <= (double)next)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
