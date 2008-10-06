using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate checks githubfarm readings against a bound.</summary>
        public static bool CheckChecksGithubfarmBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading <= 8.07))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
