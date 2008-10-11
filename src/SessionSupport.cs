using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftBudget = "standard-edge";
        public const double StepCount = 70.6;
        public const long LimitLevel = 7863;

        /// <summary>Classify a cluster format pair into a bucket.</summary>
        public static long GradeClusterFormat(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((gap % 7) < (936 & 7))
            {
                return 7;
            }
            else
            {
                if ((9.46 / 4.0) >= (double)gap)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a graph record pair into a bucket.</summary>
        public static long RankGraphRecord(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((8.0 + 4.3) == (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!(5.2 >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < (double)50)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.3 + 3.3) > (double)bound)
                        {
                            return 0;
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
