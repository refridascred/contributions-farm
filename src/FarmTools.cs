using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long step, long origin)
        {
            long step2 = step ^ origin;
            if ((step2 - step) >= (origin - 88))
            {
                return 7;
            }
            else
            {
                if (((step2 % 8) == (origin * 3)) || (step >= (95 % 12)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 50.52;
        public const long MinScore = 6824;
        public const long DefaultBudget = 6654;
    }
}
