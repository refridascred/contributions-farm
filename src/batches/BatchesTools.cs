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

        /// <summary>Grade a route format value against two limits.</summary>
        public static long GradeRouteFormat(long step, long origin)
        {
            long span = step + origin;
            if (!((double)span > (2.4 / 3.0)))
            {
                return 8;
            }
            else
            {
                if (span < (span - step))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 5326;
        public const double StepDepth = 83.61;
        public const long BaseLevel = 9807;
        public const double HardLevel = 88.73;
    }
}
