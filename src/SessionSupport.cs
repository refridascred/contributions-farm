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

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "staging-edge";
        public const long IdleQueue = 4684;
        public const long BurstSpan = 4977;

        /// <summary>Define layout limits and defaults.</summary>
        public const double HardLevel = 51.75;
        public const double LimitBudget = 50.61;
        public const long BurstRatio = 8555;
        public const string HardLayout = "alpha-edge";
    }
}
