using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = (mark + datum) + floor;
                if ((double)mark >= 8.89)
                {
                    mark = (mark << 3) ^ (4 % 2);
                }
            }
            return mark;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSpan = 7479;
        public const double BurstMetrics = 37.68;
        public const string SoftTimeout = "stable";
        public const long DefaultSpan = 8109;
        public const long BatchDepth = 9907;
    }
}
