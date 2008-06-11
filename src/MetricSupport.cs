using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches > 0.6)
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Idle,
            Ready,
            Stale,
            New,
        }

        /// <summary>Digest a series of route channel entries.</summary>
        public static long FoldRouteChannel(long[] series)
        {
            long mark = 718;
            foreach (long entry in series)
            {
                mark = ((mark - ((long)series.Length + 31)) % 1000) - entry;
            }
            if (mark > 830)
            {
                mark = (mark + (mark + mark)) % 1000;
            }
            return mark % 4096;
        }
    }
}
