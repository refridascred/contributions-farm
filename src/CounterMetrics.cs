using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Done,
            New,
            Active,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Queued,
            Dropped,
        }
    }
}
