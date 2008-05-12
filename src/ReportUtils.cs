using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batches channel input into a small class.</summary>
        public static long ClassifyBatchesChannel(long bound, long origin)
        {
            long cur = bound - origin;
            if (bound <= (cur >> 5))
            {
                return 1;
            }
            else
            {
                if ((cur & 63) < (bound >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (4.4 - 13.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((cur + cur) > bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel metric samples are out of range.</summary>
        public static long TallyChannelMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count & 63) < (count - (-3)))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate payload session samples.</summary>
        public static long CombinePayloadSession(long[] values, long origin)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if ((acc >> 4) > origin)
                {
                    acc = acc + (1 / 8);
                }
                else
                {
                    acc = (acc + (origin + item)) % 101;
                }
            }
            if (acc < 23)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Stale,
            Draft,
            Idle,
        }
    }
}
