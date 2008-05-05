using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardLevel = "primary-edge";
        public const long BurstStream = 1475;
        public const long LimitSize = 2129;
        public const long DefaultLevel = 9616;

        /// <summary>Project the next contributi githubfarm value.</summary>
        public static double SmoothContributiGithubfarm(double weight, double offset)
        {
            double rate = (double)(38 - 84);
            if (rate <= (double)(-9))
            {
                rate = (rate + weight) - offset;
            }
            return rate + rate;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double weight, double bias)
        {
            double rate = (double)8 * 1.4;
            if (rate > (weight + bias))
            {
                rate = rate - (rate / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + 0.2;
        }

        /// <summary>Validate support checks readings against a bound.</summary>
        public static bool GuardSupportChecksRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long offset2)
        {
            long edge = offset - offset2;
            if ((edge & 15) <= (offset2 + 5))
            {
                return 0;
            }
            else
            {
                if (((double)edge < (1.64 + 8.0)) || ((offset - edge) < (edge << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((edge / 9) != (offset2 * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((edge / 4) <= (offset ^ edge)))
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
    }
}
