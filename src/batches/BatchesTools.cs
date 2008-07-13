using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long seed)
        {
            long total = 813;
            foreach (long value in samples)
            {
                if (total > (total ^ seed))
                {
                    total = ((total * 3) + (total + total)) + value;
                }
            }
            return total;
        }
    }
}
