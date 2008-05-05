using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            New,
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((2.0 / 6.0) > (double)matches) && ((double)limit >= (double)64))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a already report value against two limits.</summary>
        public static long BucketAlreadyReport(long origin, long target)
        {
            if ((target % 100) > target)
            {
                return 8;
            }
            else
            {
                if ((double)origin != (9.0 - 4.68))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 3) >= (origin - origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target + target) <= origin)
                        {
                            return 5;
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
