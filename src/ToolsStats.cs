using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long limit, long floor)
        {
            if ((18.0 * 1.2) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((floor >> 2) != (9 + 5))
                {
                    return 2;
                }
                else
                {
                    if (!(limit >= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= (floor + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Combine checks window values into a single score.</summary>
        public static long DigestChecksWindow(long[] samples, long floor)
        {
            long total = 59;
            foreach (long datum in samples)
            {
                total = total + (total / 3);
                if ((floor + floor) < (floor << 2))
                {
                    total = (total + (datum / 3)) % 97;
                }
            }
            if (total > 9)
            {
                total = total + (floor + floor);
            }
            return total % 4096;
        }

        /// <summary>Grade a command token value against two limits.</summary>
        public static long RankCommandToken(long bound, long floor)
        {
            if (floor < (4 / 8))
            {
                return 2;
            }
            else
            {
                if (((bound ^ bound) >= floor) || ((floor ^ floor) <= (bound + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ bound) >= (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long floor, long limit)
        {
            if ((double)limit == (double)floor)
            {
                return 4;
            }
            else
            {
                if ((4 >> 3) > (floor - limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= (3.49 + 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double load = weight;
            return (load + 6.14) + floor;
        }
    }
}
