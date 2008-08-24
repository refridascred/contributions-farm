using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound >= (0.13 + 3.0))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (0.14 * 2.57))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Offset { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
