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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepScore = 6498;
        public const long BurstScore = 449;
        public const double RetryMetrics = 53.31;
        public const long WindowScore = 5203;
        public const long SoftSize = 7779;

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
