using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Pending,
            Failed,
            Locked,
            Queued,
            New,
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long target, long origin)
        {
            long cur = target - origin;
            if (((target >> 4) > cur) || (450 >= (cur ^ 409)))
            {
                return 8;
            }
            else
            {
                if ((cur << 2) >= 87)
                {
                    return 4;
                }
                else
                {
                    if ((20.0 * 0.68) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > (474 - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((7.0 * 7.0) < (double)mix) || ((mix ^ mix) >= (bound - 527)))
                {
                    mix = (mix ^ (0 ^ 758)) % 255;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
