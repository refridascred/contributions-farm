using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + count) <= (count & 3))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
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
