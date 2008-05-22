using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double rate = bias;
            if (rate > 8.0)
            {
                rate = rate - (0.6 - 9.2);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (bias * 6.1)) - (double)(long)i;
            }
            return rate - (bias - floor);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long step)
        {
            if (step > (offset - step))
            {
                return 8;
            }
            else
            {
                if ((643 >= (offset * 3)) && ((step - step) < (143 + offset)))
                {
                    return 7;
                }
                else
                {
                    if ((19.0 / 3.0) == (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step - step) >= 427)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many queue buffer samples are out of range.</summary>
        public static long AuditQueueBufferOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)bound >= (3.91 + 9.4))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
