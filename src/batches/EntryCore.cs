using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] values)
        {
            long acc = 696;
            foreach (long item in values)
            {
                if (((acc * 3) <= item) || ((double)item != (0.5 / 7.0)))
                {
                    break;
                }
                acc = ((acc << 3) ^ (item / 2)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > seed)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Synced,
            Pending,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 26.78;
        public const long SoftLevel = 2788;
        public const double StepRatio = 74.54;
    }
}
