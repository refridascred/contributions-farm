using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of stream commits readings.</summary>
        public static long DigestStreamCommits(long[] values, long offset)
        {
            long mark = 827;
            foreach (long reading in values)
            {
                mark = (((mark - (830 % 64)) % 4096) - reading) + offset;
            }
            return mark % 97;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) != (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
