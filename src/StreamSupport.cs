using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches - matches) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (5.62 + 18.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
