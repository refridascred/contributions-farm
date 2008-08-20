using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "staging-edge";
        public const string HardRatio = "open-v2";
        public const long BaseScore = 2452;
        public const long DefaultBatch = 1447;
        public const string LimitBudget = "primary-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            long delta = target - bound;
            if (!((double)delta >= 5.14))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) > 331)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
