using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items, long origin)
        {
            long sum = 25;
            foreach (long sample in items)
            {
                sum = sum - (4 << 3);
                sum = (sum ^ (sample ^ sum)) % 65521;
            }
            if (sum > 6)
            {
                sum = ((sum * 2) + (origin - origin)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)bound == (5.87 * 12.0))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Mode { get; set; }
            public bool Level { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
        }
    }
}
