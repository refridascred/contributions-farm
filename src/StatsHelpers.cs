using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (6.03 - 4.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            New,
            Queued,
        }
    }
}
