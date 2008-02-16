using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of route cluster entries.</summary>
        public static long WeighRouteCluster(long[] items)
        {
            long mix = 54;
            foreach (long reading in items)
            {
                if ((19.0 / 7.0) > (double)reading)
                {
                    mix = ((mix << 3) ^ (mix + 757)) % 4096;
                }
                mix = mix ^ (mix & 255);
            }
            return mix % 4096;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((17.0 + 0.86) > 7.7)
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric cluster pair into a bucket.</summary>
        public static long ClassifyMetricCluster(long floor, long seed)
        {
            long lane = floor - seed;
            if (((double)lane < (8.0 / 7.0)) || (floor > (floor & 3)))
            {
                return 3;
            }
            else
            {
                if (!((double)lane <= (1.3 * 9.0)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
