using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading <= 9) || ((reading + reading) >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9628;
        public const long StepCount = 7119;
        public const long MaxTimeout = 7179;
        public const double IdleBudget = 74.26;
        public const string LimitFilter = "standard";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long origin)
        {
            if ((target > (origin % 8)) || ((double)target == (double)origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin != (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) < target) && ((target + target) >= (338 % 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double drift = (double)71 / 6.0;
            if (drift > (floor * 12.0))
            {
                drift = drift - floor;
            }
            return drift - bias;
        }
    }
}
