using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long MeasurePayloadBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((2 & 3) > reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
