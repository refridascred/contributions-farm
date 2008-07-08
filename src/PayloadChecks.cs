using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stats channel counter forward.</summary>
        public static long DeriveStatsChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchScore = 4400;
        public const long StepNotes = 7273;
        public const long MaxDepth = 4477;
        public const long IdleNotes = 7149;
        public const long StepCount = 7237;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            New,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
