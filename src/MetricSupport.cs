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

        /// <summary>Grade a metrics filter value against two limits.</summary>
        public static long BucketMetricsFilter(long step, long target)
        {
            long prev = step ^ target;
            if ((double)prev == (8.8 / 3.0))
            {
                return 0;
            }
            else
            {
                if ((75 - 194) <= (prev + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
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
