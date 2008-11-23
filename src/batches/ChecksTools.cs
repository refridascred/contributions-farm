using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((offset * 4) >= offset)
            {
                return 6;
            }
            else
            {
                if (offset > (offset ^ limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)offset <= (double)8))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit << 1) >= (limit - 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 4228;
        public const string BurstAlready = "latest-1";
        public const string IdleCount = "standard-v2";
        public const double MaxLevel = 17.71;
        public const long BatchAlready = 1711;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string HardMetrics = "cached-1";
        public const long IdleInterval = 3836;
    }
}
