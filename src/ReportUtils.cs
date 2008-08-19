using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] data)
        {
            long mix = 2;
            foreach (long datum in data)
            {
                if ((datum % 8) >= (964 + 1))
                {
                    mix = (mix * 4) + (datum * 3);
                }
                else
                {
                    mix = (mix * 3) + datum;
                }
            }
            if (mix > 41)
            {
                mix = ((mix << 3) ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Pending,
            New,
            Closed,
            Dropped,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Synced,
            New,
            Failed,
        }
    }
}
