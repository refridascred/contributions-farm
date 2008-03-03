using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long step, long seed)
        {
            if (seed > (step & 7))
            {
                return 7;
            }
            else
            {
                if ((1 << 3) != (step - step))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 89;
        public const long SoftFilter = 2165;
        public const double HardFilter = 23.94;
        public const double BaseTimeout = 55.88;
        public const string IdleLevel = "standard-1";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Done,
            Dropped,
            Draft,
        }
    }
}
