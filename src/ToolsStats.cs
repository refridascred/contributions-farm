using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long result = 51;
            foreach (long reading in values)
            {
                if ((double)result >= (3.5 * 20.0))
                {
                    result = (result + reading) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate window githubfarm samples.</summary>
        public static long DigestWindowGithubfarm(long[] items, long seed)
        {
            long mark = 0;
            foreach (long reading in items)
            {
                mark = ((((mark << 2) ^ (mark % 2)) % 65521) - reading) - seed;
            }
            if (mark > (-496))
            {
                mark = mark ^ (mark * 2);
            }
            return mark;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum % 7)) + cell;
            }
            if (sum < (-85))
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }
    }
}
