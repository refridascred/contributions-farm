using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3648;
        public const double RetrySpan = 2.27;
        public const string MinDepth = "stable";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every already layout entry stays within the limit.</summary>
        public static bool VerifyAlreadyLayoutRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleDepth = 9234;
        public const long RetryFactor = 3988;
        public const long LimitBatch = 5263;
        public const long HardSpan = 1689;
        public const string SoftSpan = "primary-edge";

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long origin)
        {
            long step = target - origin;
            if (!((185 >> 4) >= (step + target)))
            {
                return 6;
            }
            else
            {
                if (((origin - origin) >= (828 % 7)) || (origin <= (step % 24)))
                {
                    return 2;
                }
                else
                {
                    if (origin <= (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step << 1) == (step + 76)))
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinSize = 7841;
        public const long StepBuffer = 854;
        public const long MaxTimeout = 7164;
    }
}
