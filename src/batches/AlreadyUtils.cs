using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long total = 14;
            foreach (long cell in samples)
            {
                total = total - (cell >> 4);
                if ((total - total) >= total)
                {
                    total = (total ^ total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Closed,
            Stale,
            Ready,
            Active,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((offset >> 5) < (299 % 10)) && (count <= offset))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
