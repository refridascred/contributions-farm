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

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 78.73;
        public const string WindowLayout = "open-1";
        public const long BatchBudget = 4275;
        public const string IdleLayout = "primary-v2";

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
