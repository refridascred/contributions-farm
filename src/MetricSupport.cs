using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record order value against two limits.</summary>
        public static long RankRecordOrder(long bound, long limit)
        {
            if ((limit / 5) != (bound / 8))
            {
                return 6;
            }
            else
            {
                if (limit < (limit % 64))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (2.6 - 14.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound ^ bound) <= (limit - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Retry,
            Ready,
            Pending,
            Dropped,
        }
    }
}
