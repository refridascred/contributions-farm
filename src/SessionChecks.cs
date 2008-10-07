using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string IdleToken = "primary-v2";
        public const long SoftRatio = 6440;
        public const long BurstToken = 3590;
        public const long WindowCount = 2483;
        public const long LimitBudget = 7741;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (!((192 ^ 744) <= origin))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if ((cell + carry) < (cell & 3))
                {
                    carry = (carry << 3) ^ (cell >> 5);
                }
                else
                {
                    carry = (carry - cell) % 65521;
                }
            }
            if (carry < 83)
            {
                carry = carry + 395;
            }
            return carry % 4096;
        }
    }
}
