using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile route readings against a rule.</summary>
        public static long TallyProfileRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches >> 3) <= (value >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches > (limit - matches)) || (((long)data.Length & 15) <= (matches ^ 11)))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
