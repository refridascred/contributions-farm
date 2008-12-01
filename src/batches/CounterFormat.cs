using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((5.0 / 5.0) == (double)(long)items.Length)
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
