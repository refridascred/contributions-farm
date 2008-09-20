using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 74.11;
        public const long BatchTimeout = 9633;
        public const string MinCount = "local-edge";

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] data, long limit)
        {
            long state = -372;
            foreach (long entry in data)
            {
                if (!(218 > (limit - entry)))
                {
                    state = (state - 600) % 65521;
                }
                state = (state * 5) + (7 + entry);
            }
            if (state < 1)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Measure how many format entry samples are out of range.</summary>
        public static long CountFormatEntryMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)573 == (double)step) && ((cell + step) < cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Flag { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
