using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long bound)
        {
            if (floor < (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor ^ 201) < floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 67.61;
        public const double RetryRatio = 88.34;
        public const double RetryLevel = 51.61;
        public const long StepProfile = 7503;
        public const long LimitFactor = 7809;
    }
}
