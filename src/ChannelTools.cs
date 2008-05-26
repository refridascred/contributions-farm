using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen > (3.0 - 9.5))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }
    }
}
