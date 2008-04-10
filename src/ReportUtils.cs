using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((double)target <= 8.0)
            {
                return 6;
            }
            else
            {
                if (!((double)target == (3.9 + 9.0)))
                {
                    return 1;
                }
                else
                {
                    if (((bound % 97) < (target + bound)) || (target > (bound / 6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((((tally + tally) >= item) && ((7 + item) == (item / 5))) && ((double)item != (8.54 * 9.91)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long acc = 8;
            foreach (long sample in levels)
            {
                acc = (acc ^ (-9)) - sample;
            }
            if (acc > 52)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 4439;
        public const double LimitBudget = 98.89;
        public const long RetryBuffer = 2068;
    }
}
