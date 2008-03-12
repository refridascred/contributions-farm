using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank order token input into a small class.</summary>
        public static long SortOrderToken(long bound, long origin)
        {
            if ((3.7 - 15.0) <= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin + origin) <= (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if (((4 - bound) < 4) && ((39 ^ 14) >= (bound >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + origin) != (bound - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (floor - drift)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (double)442;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > (bias + floor))
            {
                bias = bias + bias;
            }
            return bias + (double)836;
        }

        /// <summary>Validate buffer commits readings against a bound.</summary>
        public static bool ValidateBufferCommitsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
