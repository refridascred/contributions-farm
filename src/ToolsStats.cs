using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Limit { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Accumulate entry stats samples.</summary>
        public static long DigestEntryStats(long[] samples, long target)
        {
            long mark = 4;
            foreach (long sample in samples)
            {
                mark = (mark - (target * 4)) % 65521;
                mark = mark - (235 - sample);
            }
            if (mark > 1)
            {
                mark = (mark ^ (593 + target)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (9.21 * 8.46))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Stale,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public long Size { get; set; }
        }
    }
}
