using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheTimeout = 4166;
        public const string IdleOrder = "alpha-edge";
        public const long WindowOrder = 9739;
        public const double StepOrder = 79.93;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long state = -952;
            foreach (long entry in samples)
            {
                state = state - (entry + state);
                if ((state < (state << 1)) || ((double)11 <= (double)entry))
                {
                    state = state + entry;
                }
            }
            return state;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
