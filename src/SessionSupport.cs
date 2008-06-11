using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long target2)
        {
            if ((4.49 < (double)target) && ((0 >> 1) > (target * 5)))
            {
                return 3;
            }
            else
            {
                if ((target2 >> 4) > (target % 97))
                {
                    return 5;
                }
                else
                {
                    if (7.36 >= (double)target2)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((815 >> 2) == (target2 - target2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 33.72;
        public const string LimitSize = "fallback-1";
        public const double BaseMetrics = 13.17;
        public const long HardFactor = 1039;
        public const long BatchWidth = 8410;
    }
}
