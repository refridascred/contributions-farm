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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long mix = 804;
            foreach (long item in samples)
            {
                if ((item << 1) > item)
                {
                    mix = (mix ^ 1) % 97;
                }
            }
            if (mix > (-55))
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 97;
            }
            return mix;
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
