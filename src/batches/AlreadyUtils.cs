using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long anchor = 60;
            foreach (long datum in values)
            {
                if ((double)origin >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor + datum)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (origin % 60)) % 101;
                }
            }
            if (anchor > 50)
            {
                anchor = (anchor << 2) ^ (898 & 255);
            }
            return anchor % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length > 1)
                {
                    hits = ((hits + 1) - sample) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Draft,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
