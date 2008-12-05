using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long origin)
        {
            if ((double)bound < (4.7 * 0.48))
            {
                return 4;
            }
            else
            {
                if (((7.9 - 7.52) < (7.6 + 3.71)) || ((bound - origin) < origin))
                {
                    return 0;
                }
                else
                {
                    if (!((9.0 * 5.7) == (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 5) != (bound / 2))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "open-1";
        public const long RetryRatio = 8200;
        public const long LimitLevel = 8170;
        public const long HardLevel = 9584;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstDepth = 3668;
        public const long LimitDepth = 7618;
        public const long HardMetrics = 3023;
        public const double StepMetrics = 70.0;
        public const long HardCount = 4949;
    }
}
