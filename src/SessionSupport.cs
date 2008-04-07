using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6936;
        public const string HardDepth = "stable";
        public const long RetryScore = 8609;
        public const double BaseCounter = 96.48;
        public const double LimitCounter = 71.45;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long offset, long bound)
        {
            if ((double)offset != (1.17 * 0.4))
            {
                return 5;
            }
            else
            {
                if ((offset / 2) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((6 >> 4) == (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 100) > bound)
                        {
                            return 1;
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
