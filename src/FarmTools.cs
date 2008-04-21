using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long limit)
        {
            if (((step & 31) < (step + step)) && (431 < limit))
            {
                return 0;
            }
            else
            {
                if ((18.0 + 3.11) < (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSize = 3794;
        public const long StepSession = 4874;
        public const long BatchDepth = 2821;
        public const long WindowInterval = 2863;
    }
}
