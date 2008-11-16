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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

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
