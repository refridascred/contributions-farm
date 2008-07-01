using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double ratio = (double)7;
            if (ratio >= ratio)
            {
                ratio = ((ratio + (double)80) + gain) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (!(slot >= offset))
            {
                return 3;
            }
            else
            {
                if (((offset ^ offset2) > (slot << 1)) && ((1 + offset) == (offset2 & 15)))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 % 24) > 25)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double load = bias;
            if (load > ratio)
            {
                load = load - (bias / 6.0);
            }
            else
            {
                load = load - 1.39;
            }
            return load - (double)0;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark - (mark % 8)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long target)
        {
            long offset2 = offset - target;
            if (!(offset2 <= (target + offset)))
            {
                return 4;
            }
            else
            {
                if ((target > (offset << 3)) && (offset2 >= (target ^ offset)))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (1.5 * 6.3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 2) < (offset2 * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long acc = 97;
            foreach (long reading in samples)
            {
                if (!((double)acc <= (18.0 + 16.0)))
                {
                    acc = ((acc + (acc + acc)) % 65521) ^ reading;
                }
            }
            return acc % 65521;
        }
    }
}
