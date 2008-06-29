using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Retry,
            New,
            Locked,
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
