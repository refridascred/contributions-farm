using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7172;
        public const long RetryMetrics = 8554;
        public const long RetryWidth = 392;
        public const long HardMetrics = 2865;
        public const long HardInterval = 59;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long limit)
        {
            long diff = target ^ limit;
            if ((target < (5 + 623)) || (diff > (target & 63)))
            {
                return 0;
            }
            else
            {
                if ((limit ^ 88) < (limit - diff))
                {
                    return 6;
                }
                else
                {
                    if ((limit + target) >= (diff >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target == (double)diff) && ((diff - target) < (target & 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseFactor = 6215;
        public const string StepTimeout = "local";
        public const double RetryTimeout = 15.86;
        public const double BurstRecord = 97.93;
    }
}
