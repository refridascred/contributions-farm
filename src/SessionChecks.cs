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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long origin)
        {
            if ((step + origin) >= (step << 2))
            {
                return 1;
            }
            else
            {
                if ((step >> 5) != (step / 3))
                {
                    return 3;
                }
                else
                {
                    if (!(9.3 >= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step >= (8.34 - 6.65))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
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
