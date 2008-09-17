using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-edge";
        public const long MaxEditor = 2383;
        public const string DefaultRatio = "legacy";
        public const long SoftDepth = 3211;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Dropped,
            Active,
            Locked,
            Done,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long origin, long bound)
        {
            if ((bound * 2) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound << 1) == (origin % 5))
                {
                    return 8;
                }
                else
                {
                    if (!((bound ^ bound) <= (79 & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
