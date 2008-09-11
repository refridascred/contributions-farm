using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] series, long origin)
        {
            long score = -9;
            foreach (long cell in series)
            {
                if (((403 % 5) < (score / 5)) && ((cell + score) > (score / 4)))
                {
                    score = (((score * 3) + (cell ^ score)) % 4096) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Failed,
            Paused,
        }
    }
}
