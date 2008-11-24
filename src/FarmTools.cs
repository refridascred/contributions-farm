using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Combine commits report values into a single score.</summary>
        public static long ScoreCommitsReport(long[] data)
        {
            long score = 69;
            foreach (long cell in data)
            {
                score = score + (cell + score);
                if ((cell - score) == (score + cell))
                {
                    score = score + (score * 3);
                }
            }
            if (score < 63)
            {
                score = (score - score) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
