using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples)
        {
            long carry = 5;
            foreach (long entry in samples)
            {
                if ((entry & 7) <= (entry >> 5))
                {
                    carry = carry + (entry - carry);
                }
                else
                {
                    carry = carry + (entry % 24);
                }
            }
            return carry;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Ready,
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Iterate the stats counter series from a seed.</summary>
        public static long SeriesStatsCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ offset;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
