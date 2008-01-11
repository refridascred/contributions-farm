using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if ((datum + datum) < carry)
                {
                    carry = (carry - (carry >> 2)) % 1000;
                    carry = (carry + (datum << 1)) % 4096;
                }
                carry = (carry - (carry + 0)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Stale,
            Failed,
            Locked,
        }
    }
}
