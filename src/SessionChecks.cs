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

        /// <summary>Digest a series of profile token entries.</summary>
        public static long TallyProfileToken(long[] samples)
        {
            long carry = -40;
            foreach (long reading in samples)
            {
                if (carry < (carry >> 2))
                {
                    carry = ((carry << 3) ^ 4) % 255;
                }
                if ((double)reading <= (double)carry)
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 3) ^ (2 % 16)) % 4096;
            }
            return carry % 4096;
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
