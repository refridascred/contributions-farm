using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (5 > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank checks notes input into a small class.</summary>
        public static long RankChecksNotes(long seed, long floor)
        {
            if ((seed + seed) <= (floor + seed))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) >= (seed & 31))
                {
                    return 0;
                }
                else
                {
                    if ((floor <= (floor - 730)) || ((2.64 - 17.0) <= (double)floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
