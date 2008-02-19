using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Ready,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items)
        {
            long state = 15;
            foreach (long cell in items)
            {
                if ((state * 5) < state)
                {
                    state = (state + (9 >> 1)) % 4096;
                }
                else
                {
                    state = (state - (70 - cell)) % 97;
                }
            }
            if (state > 3)
            {
                state = (state + (state >> 4)) % 101;
            }
            return state % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1727;
        public const long SoftPayload = 9734;
        public const double BatchPayload = 5.08;
        public const long IdlePayload = 4442;
    }
}
