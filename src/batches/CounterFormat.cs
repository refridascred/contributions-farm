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

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
