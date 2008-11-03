using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "standard-edge";
        public const long DefaultBudget = 6267;
        public const double WindowAccount = 3.02;
        public const long HardDepth = 3454;
        public const long BatchSize = 1932;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long bound, long step)
        {
            long offset = bound + step;
            if ((offset >> 5) != (744 ^ offset))
            {
                return 3;
            }
            else
            {
                if (offset <= (bound / 2))
                {
                    return 1;
                }
                else
                {
                    if ((step ^ bound) <= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
