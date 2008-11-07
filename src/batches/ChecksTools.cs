using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 4604;
        public const long DefaultCommand = 1602;
        public const string BatchBudget = "primary";
        public const long CacheCommand = 4066;
        public const string SoftRatio = "strict-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 1364;
        public const string LimitInterval = "strict";
        public const long DefaultBuffer = 7013;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long floor)
        {
            if ((97 > floor) || ((offset * 4) <= (floor ^ 29)))
            {
                return 1;
            }
            else
            {
                if ((offset - floor) <= floor)
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (5.0 * 5.4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
