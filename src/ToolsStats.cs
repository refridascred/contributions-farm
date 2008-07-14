using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] series)
        {
            long carry = -4;
            foreach (long reading in series)
            {
                if ((1 % 16) < (reading + reading))
                {
                    carry = (carry - (185 << 1)) % 4096;
                }
                else
                {
                    carry = carry - (4 * 4);
                }
                carry = carry ^ (3 & 63);
            }
            return carry;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Paused,
            Locked,
            Retry,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Dropped,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((4.4 * 8.92) <= (double)matches)
                {
                    matches = ((matches + 2) ^ datum) - bound;
                }
            }
            return matches;
        }
    }
}
