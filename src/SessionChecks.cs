using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                if ((((long)data.Length % 3) > (cell * 4)) || ((15.0 - 5.7) < (double)cell))
                {
                    sum = ((sum << 3) ^ (sum * 5)) % 101;
                }
            }
            if (sum > 8)
            {
                sum = ((sum * 2) + (sum >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Idle,
            Failed,
            Draft,
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
