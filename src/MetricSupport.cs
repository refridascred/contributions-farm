using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell > (cell + hits)) || !(cell > (cell - cell)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
