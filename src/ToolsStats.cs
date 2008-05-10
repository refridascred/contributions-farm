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

        /// <summary>Count the githubfarm context entries that pass the check.</summary>
        public static long TallyGithubfarmContextGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Idle,
            Dropped,
            Stale,
            New,
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
