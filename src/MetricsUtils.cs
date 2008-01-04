using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 4967;
        public const long SoftBudget = 3600;
        public const long HardSize = 1227;
        public const double BurstCount = 96.01;
        public const long IdleMetrics = 5689;

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long origin)
        {
            long step = seed - origin;
            if (seed >= (seed + origin))
            {
                return 1;
            }
            else
            {
                if (step > (step + (-231)))
                {
                    return 5;
                }
                else
                {
                    if ((4.0 * 18.0) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((6.95 - 6.72) > (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftScore = 4727;
        public const double HardScore = 22.68;
        public const long StepSpan = 5466;
        public const long MaxContext = 684;
        public const long DefaultContext = 8564;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBudget = 94.64;
        public const long MaxSpan = 9641;
        public const long WindowLevel = 7440;
        public const string BurstBuffer = "stable-1";
        public const long WindowCount = 7468;

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
