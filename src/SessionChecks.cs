using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long floor)
        {
            long anchor = 52;
            foreach (long cell in levels)
            {
                anchor = ((anchor + ((-29) + anchor)) - cell) + floor;
            }
            return anchor;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + offset) > (reading / 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a metric batches pair into a bucket.</summary>
        public static long BucketMetricBatches(long limit, long step)
        {
            long prev = limit - step;
            if ((limit % 24) > (782 + prev))
            {
                return 5;
            }
            else
            {
                if ((limit >= (step - 21)) && ((prev + 2) < step))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
