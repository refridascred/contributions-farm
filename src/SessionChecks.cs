using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two metrics filter measurements.</summary>
        public static double ProjectMetricsFilter(double bias, double span)
        {
            double weight = span;
            if (weight <= bias)
            {
                weight = weight - (weight / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (bias * 19.0);
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long floor, long offset)
        {
            if ((double)offset != (6.6 / 4.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor + floor) >= (74 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (9 & 63))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long floor, long origin)
        {
            long diff = floor - origin;
            if ((7.78 / 9.0) != (double)diff)
            {
                return 1;
            }
            else
            {
                if (((double)diff >= (10.0 / 2.0)) || ((floor & 255) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((diff ^ origin) > (origin & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff >= (69 % 97)) || ((8.04 * 10.0) <= (double)diff))
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

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
