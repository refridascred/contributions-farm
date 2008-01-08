using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftInterval = 71.81;
        public const string StepCount = "latest-edge";
        public const long CacheDepth = 1352;
        public const long SoftSpan = 933;
        public const long DefaultChecks = 1027;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long origin)
        {
            if (!((double)origin == (double)0))
            {
                return 2;
            }
            else
            {
                if (((target + origin) >= (target - target)) && ((93 % 24) >= (target << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((target & 3) < origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Active,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Ready,
            Retry,
        }
    }
}
