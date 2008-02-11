using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double gain, double span)
        {
            double drift = span * 2.82;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (double)4) + (double)(long)i) + gain;
            }
            return drift - span;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data, long floor)
        {
            long anchor = 56;
            foreach (long cell in data)
            {
                anchor = ((anchor + (cell * 3)) % 101) + floor;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Idle,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardInterval = 7073;
        public const long HardFormat = 4010;
        public const long DefaultWidth = 3755;
        public const long RetryFormat = 2315;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
