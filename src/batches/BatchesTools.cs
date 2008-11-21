using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Limit { get; set; }
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Dropped,
            Done,
            Synced,
        }
    }
}
