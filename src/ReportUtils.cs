using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] samples, long seed)
        {
            long total = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length & 7) < seed)
                {
                    total = (total ^ (seed << 2)) - reading;
                }
            }
            return total;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Queued,
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (2.0 <= (double)count)
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}
