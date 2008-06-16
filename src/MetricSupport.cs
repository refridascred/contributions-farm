using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a order batches pair into a bucket.</summary>
        public static long RankOrderBatches(long origin, long step)
        {
            long lane = origin - step;
            if (!((27 + origin) > (lane + step)))
            {
                return 1;
            }
            else
            {
                if ((14.0 * 6.43) < (13.0 - 1.7))
                {
                    return 5;
                }
                else
                {
                    if (((13 + lane) > 17) || ((step << 1) >= (step / 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
