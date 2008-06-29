using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit commits record readings against a rule.</summary>
        public static long MeasureCommitsRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry > (hits + entry)) || ((62 + hits) <= ((long)series.Length + hits))) || (((entry + hits) <= (entry / 9)) && ((hits + hits) < entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Dropped,
            Failed,
            New,
        }
    }
}
