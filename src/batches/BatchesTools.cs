using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + (anchor & 7)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 5326;
        public const double StepDepth = 83.61;
        public const long BaseLevel = 9807;
        public const double HardLevel = 88.73;
    }
}
