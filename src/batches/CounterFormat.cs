using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 4850;
        public const long MinRecord = 5074;
        public const long SoftRecord = 8258;
        public const long StepScore = 4177;
        public const double RetrySize = 32.48;

        /// <summary>Derive the next queue context value from a seed.</summary>
        public static long SeriesQueueContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry << 2) ^ 43) % 4096;
                carry = ((carry * 5) + (limit - carry)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Owner { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
        }
    }
}
