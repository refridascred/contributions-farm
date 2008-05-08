using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Closed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Grade a command batch value against two limits.</summary>
        public static long ClassifyCommandBatch(long offset, long target)
        {
            long gap = offset ^ target;
            if (((double)offset >= (18.0 / 7.0)) && ((double)offset <= (double)29))
            {
                return 4;
            }
            else
            {
                if (!((gap / 6) == (target ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((4.1 / 7.0) != (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >> 2) <= (-4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch token reading by value.</summary>
        public static long LocateBatchTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((seed + value) <= (hits ^ hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
