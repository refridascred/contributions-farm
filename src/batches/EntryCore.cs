using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (bound <= 20)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((853 + step) < (step >> 5)) || ((step + step) != (step << 2)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values)
        {
            long total = 8;
            foreach (long item in values)
            {
                if ((total - item) <= total)
                {
                    total = ((total * 5) + (item - item)) % 65521;
                }
                if (item <= 239)
                {
                    break;
                }
            }
            if (total < (-24))
            {
                total = total - (total - total);
            }
            return total;
        }
    }
}
