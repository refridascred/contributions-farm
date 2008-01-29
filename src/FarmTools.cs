using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if ((seed < (seed2 << 2)) && ((double)4 <= (double)seed2))
            {
                return 4;
            }
            else
            {
                if ((double)seed2 < (5.0 + 4.9))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 / 4) != (seed2 >> 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 48.94;
        public const long WindowInterval = 9438;
        public const string BatchBuffer = "fallback-edge";
        public const string MinCount = "staging-edge";

        /// <summary>Grade a channel cluster value against two limits.</summary>
        public static long SortChannelCluster(long bound, long bound2)
        {
            if (!((bound / 2) <= (bound ^ bound)))
            {
                return 0;
            }
            else
            {
                if (2 >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((bound > (bound / 7)) && ((double)bound2 != (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound >> 4) >= (631 >> 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
