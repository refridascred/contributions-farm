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

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepBudget = 7230;
        public const string MaxChannel = "latest-1";
        public const long MaxCount = 3432;
        public const long CacheChannel = 7525;
    }
}
