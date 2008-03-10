using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Failed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item * 5) == (hits << 1)) && ((5 + hits) < item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
            public bool Region { get; set; }
        }
    }
}
