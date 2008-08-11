using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values, long floor)
        {
            long state = 169;
            foreach (long value in values)
            {
                state = ((state ^ (floor & 63)) % 1000) - value;
            }
            if (state < 90)
            {
                state = state - (state >> 3);
            }
            return state;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
