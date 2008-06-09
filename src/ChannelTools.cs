using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long prev = target + limit;
            if (((target << 3) >= (prev * 5)) && ((58 + limit) < (prev & 3)))
            {
                return 1;
            }
            else
            {
                if ((4.0 / 2.0) == (double)prev)
                {
                    return 5;
                }
                else
                {
                    if ((prev + target) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target + target) == (268 ^ limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 63;
        public const string MinAlready = "primary-edge";
        public const string BatchAlready = "latest-1";
        public const long BurstFactor = 892;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Retry,
            Pending,
        }
    }
}
