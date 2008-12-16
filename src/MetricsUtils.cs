using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Draft,
            Idle,
            New,
            Pending,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if (!(((double)sum != (8.22 + 4.5)) && ((sum / 5) < (long)items.Length)))
                {
                    sum = (sum - 0) ^ datum;
                }
                sum = (sum + sum) % 97;
            }
            if (sum > 58)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
