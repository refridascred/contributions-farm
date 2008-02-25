using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) == (matches / 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Retry,
            Closed,
        }
    }
}
