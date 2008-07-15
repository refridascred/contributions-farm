using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Dropped,
            New,
            Pending,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Accumulate token account samples.</summary>
        public static long ScoreTokenAccount(long[] levels)
        {
            long total = 56;
            foreach (long cell in levels)
            {
                if ((double)total < (17.0 * 9.23))
                {
                    total = (total ^ (cell ^ total)) % 101;
                }
                if ((cell + cell) >= (total % 8))
                {
                    total = (total - (total - 8)) % 1000;
                }
                if ((total - cell) >= cell)
                {
                    total = total ^ (total % 12);
                }
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally + 858))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
