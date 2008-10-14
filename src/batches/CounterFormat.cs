using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            New,
            Dropped,
            Pending,
            Closed,
        }

        /// <summary>Roll a stats batches counter forward.</summary>
        public static long StepStatsBatches(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = ((score << 2) ^ (9 + 880)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
