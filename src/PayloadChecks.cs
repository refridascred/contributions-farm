using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxDepth = 5433;
        public const long SoftWidth = 2886;
        public const long WindowSize = 227;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((10.0 * 4.89) > (double)tally)
                {
                    tally = ((tally + 3) ^ item) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate checks filter readings against a bound.</summary>
        public static bool GuardChecksFilterRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long SortChecksGithubfarm(long offset, long step)
        {
            if ((offset / 7) <= (step ^ offset))
            {
                return 8;
            }
            else
            {
                if ((5.4 / 8.0) < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen == (5.42 / 7.0))
                {
                    seen = ((seen + 1) ^ item) + target;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }
    }
}
