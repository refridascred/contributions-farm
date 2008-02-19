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

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinWidth = "primary-edge";
        public const string LimitStream = "open-v2";
        public const string BurstStream = "staging-v2";
        public const double SoftSpan = 50.58;
        public const long HardTimeout = 7416;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if (anchor >= (9 + bound))
                {
                    anchor = (anchor - (392 << 3)) % 4096;
                    anchor = anchor - bound;
                }
                else
                {
                    anchor = (anchor - (bound << 2)) % 4096;
                }
                anchor = (anchor + (28 + anchor)) % 101;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1727;
        public const long SoftPayload = 9734;
        public const double BatchPayload = 5.08;
        public const long IdlePayload = 4442;
    }
}
