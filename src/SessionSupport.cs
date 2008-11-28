using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSpan = 6082;
        public const long LimitSupport = 7993;
        public const double DefaultSupport = 88.44;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long origin, long floor)
        {
            if (((origin - origin) > (floor + origin)) || (floor < (floor + 8)))
            {
                return 4;
            }
            else
            {
                if ((floor * 4) > (floor + 36))
                {
                    return 5;
                }
                else
                {
                    if (5.6 > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.66 / 2.0) < (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
