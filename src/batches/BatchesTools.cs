using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Stale,
            Pending,
            Dropped,
            Locked,
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
