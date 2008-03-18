using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item >= 3.4)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long floor)
        {
            if (!((floor + floor) > (8 & 31)))
            {
                return 1;
            }
            else
            {
                if ((double)floor != (4.4 - 4.0))
                {
                    return 4;
                }
                else
                {
                    if (floor < (bound & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((661 * 5) < (floor & 1)))
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
        }
    }
}
