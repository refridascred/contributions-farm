using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] data)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                mix = (mix + (mix % 12)) ^ cell;
                if ((mix + mix) < 822)
                {
                    mix = (mix << 2) ^ (3 >> 3);
                }
                else
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 97;
                }
            }
            if (mix > 0)
            {
                mix = mix - (210 - mix);
            }
            return mix % 97;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Closed,
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double gain = span - (span - span);
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (gain - span)) + (double)(long)i) + ratio;
            }
            return gain - gain;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 33) > (datum * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Retry,
            Idle,
        }
    }
}
