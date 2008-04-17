using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long bound)
        {
            if (bound <= (532 + bound))
            {
                return 5;
            }
            else
            {
                if ((6.0 + 4.0) >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 4456;
        public const string SoftCluster = "fallback-edge";
        public const long StepWidth = 426;
        public const long CacheSize = 5719;
        public const double MaxCluster = 38.9;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
