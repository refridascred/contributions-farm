using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Locked,
            Active,
            Paused,
            Stale,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
