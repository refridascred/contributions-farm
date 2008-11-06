using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleCount = 976;
        public const long WindowSpan = 3444;
        public const long DefaultSize = 8539;
        public const long StepLevel = 3072;
        public const long HardTimeout = 2877;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate graph cache samples.</summary>
        public static long DigestGraphCache(long[] readings)
        {
            long mark = 48;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ mark) % 97) - sample;
            }
            return mark;
        }
    }
}
