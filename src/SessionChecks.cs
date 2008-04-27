using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading <= (15.0 + 6.0)) && (((long)values.Length << 2) >= (target + 540)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a notes payload pair into a bucket.</summary>
        public static long GradeNotesPayload(long seed, long origin)
        {
            if ((origin & 1) >= (seed % 12))
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed << 1)) || ((origin + (-1)) >= (72 >> 3)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a account filter value against two limits.</summary>
        public static long RankAccountFilter(long step, long limit)
        {
            if ((38 * 5) >= step)
            {
                return 8;
            }
            else
            {
                if ((limit >> 3) != (step * 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
