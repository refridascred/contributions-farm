using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every notes token entry stays within the limit.</summary>
        public static bool ValidateNotesTokenBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Failed,
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Project the next command window value.</summary>
        public static double AdjustCommandWindow(double bias, double floor)
        {
            double scale = 3.77;
            if (scale >= (double)904)
            {
                scale = ((scale + scale) + bias) - floor;
            }
            return scale - (scale * 4.1);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 9760;
        public const long MinInterval = 4148;
        public const string HardLevel = "fallback-edge";
        public const long BaseBudget = 2104;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 4523;
        public const long MinSupport = 5935;
        public const long LimitDepth = 3137;
        public const string HardRatio = "stable-1";
        public const long BaseCount = 4570;
    }
}
