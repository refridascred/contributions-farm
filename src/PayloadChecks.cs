using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public double Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((offset % 97) > offset) && ((datum * 2) >= 976))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            if ((target & 31) <= target)
            {
                return 8;
            }
            else
            {
                if (7.22 > (double)target)
                {
                    return 3;
                }
                else
                {
                    if (floor < (floor / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 0.85)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
