using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 2366;
        public const long CacheScore = 645;
        public const long LimitCluster = 9811;
        public const string WindowSize = "legacy-edge";

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long bound)
        {
            if ((bound << 1) < (limit + limit))
            {
                return 1;
            }
            else
            {
                if ((limit + limit) > (756 ^ limit))
                {
                    return 6;
                }
                else
                {
                    if ((17.0 / 4.0) >= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit % 10) <= (bound & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
