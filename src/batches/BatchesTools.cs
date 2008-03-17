using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry % 64) != (hits ^ hits))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Dropped,
            Closed,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
