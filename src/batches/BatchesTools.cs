using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm metrics value from a seed.</summary>
        public static long RollFarmMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (floor < ((long)i + anchor))
                {
                    anchor = anchor + (floor + (long)i);
                }
                else
                {
                    anchor = (anchor - 2) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 4378;
        public const long MinDepth = 8628;
        public const long RetrySize = 3805;
        public const double IdleMetrics = 65.79;
        public const double DefaultLevel = 61.39;
    }
}
