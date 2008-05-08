using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Dropped,
            New,
            Active,
            Pending,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] series)
        {
            long score = 815;
            foreach (long datum in series)
            {
                score = ((score - (score * 3)) % 4096) - datum;
            }
            if (score > 9)
            {
                score = score - (long)series.Length;
            }
            return score;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
