using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = 65;
            foreach (long datum in readings)
            {
                if (((22 - datum) < carry) && ((double)carry == (double)9))
                {
                    carry = (carry - datum) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Dropped,
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long result = 8;
            foreach (long value in data)
            {
                if (!(result > (value - value)))
                {
                    result = (result ^ (result >> 3)) % 101;
                }
                if ((double)value < (13.0 + 4.0))
                {
                    result = ((result << 2) ^ (value + result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
