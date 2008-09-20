using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool CheckFormatFilterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1287;
        public const double WindowLevel = 2.24;
        public const string HardStats = "stable";

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLevel = 51.75;
        public const double LimitBudget = 50.61;
        public const long BurstRatio = 8555;
        public const string HardLayout = "alpha-edge";
    }
}
