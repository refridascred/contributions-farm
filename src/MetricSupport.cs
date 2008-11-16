using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 2083;
        public const double RetryTools = 61.33;
        public const string MaxTools = "stable-v2";
        public const double SoftScore = 2.9;
        public const double DefaultCount = 64.09;

        /// <summary>Classify a farm metric pair into a bucket.</summary>
        public static long ClassifyFarmMetric(long floor, long step)
        {
            long prev = floor ^ step;
            if (step >= (step % 7))
            {
                return 1;
            }
            else
            {
                if ((3.31 - 2.89) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((floor + prev) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step % 97) > (step % 60)) || ((prev + prev) > (prev % 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
