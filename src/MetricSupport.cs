using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Synced,
            Closed,
            Done,
            New,
        }

        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long AuditEditorFarmOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample - limit) == (6 & 255)) && (limit >= (sample >> 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
