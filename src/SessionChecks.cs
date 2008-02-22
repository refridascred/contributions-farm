using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine entry token values into a single score.</summary>
        public static long CombineEntryToken(long[] samples)
        {
            long carry = 989;
            foreach (long cell in samples)
            {
                carry = (carry + (909 & 127)) ^ cell;
            }
            if (carry < 668)
            {
                carry = (carry << 2) ^ (188 & 1);
            }
            return carry % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 17.69;
        public const double LimitSpan = 48.18;
        public const long WindowWidth = 2683;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9768;
        public const long RetryOrder = 8533;
        public const long MaxOrder = 7062;
        public const long SoftOrder = 2558;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Done,
            Draft,
            Paused,
        }
    }
}
