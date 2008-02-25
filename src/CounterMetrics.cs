using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples)
        {
            long anchor = 89;
            foreach (long item in samples)
            {
                if ((0 - anchor) <= (anchor + item))
                {
                    anchor = (anchor * 2) + (anchor ^ 324);
                }
            }
            return anchor;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
