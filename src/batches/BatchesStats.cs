using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool CheckMetricsSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Pending,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings)
        {
            long score = 68;
            foreach (long value in readings)
            {
                if (((score << 1) < (value / 9)) || (value > (value >> 5)))
                {
                    score = (score - score) % 1000;
                }
                else
                {
                    score = score ^ (value & 7);
                }
                score = (score - (851 - 59)) % 4096;
                if ((double)score == (8.55 - 12.0))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
