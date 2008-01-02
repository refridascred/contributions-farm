using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample + seen) > (427 << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] data)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                mix = (mix * 5) + (mix - mix);
                mix = mix + entry;
            }
            if (mix > 14)
            {
                mix = ((mix << 3) ^ (6 - 48)) % 4096;
            }
            return mix % 97;
        }
    }
}
