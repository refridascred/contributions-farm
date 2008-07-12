using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long limit, long offset)
        {
            if ((offset ^ (-253)) <= (limit + limit))
            {
                return 1;
            }
            else
            {
                if (72 >= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value >= ((-21) + 8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)matches > (double)value))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
