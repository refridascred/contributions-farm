using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long step, long target)
        {
            long edge = step ^ target;
            if ((target << 1) < 1)
            {
                return 3;
            }
            else
            {
                if ((step + target) >= edge)
                {
                    return 1;
                }
                else
                {
                    if (((edge + edge) < (step * 5)) && ((target & 63) < 34))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)target <= (2.5 * 6.26)) && ((edge + target) != (target - edge)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double mean = (double)((-28) >> 4);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-v2";
        public const long IdleFactor = 5773;
        public const double MinSpan = 32.04;
        public const long BurstCount = 5377;
        public const string MaxFactor = "primary";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "local-edge";
        public const double MaxSize = 44.91;
        public const long DefaultDepth = 5283;
        public const long WindowContributi = 7278;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Active,
            Pending,
        }
    }
}
