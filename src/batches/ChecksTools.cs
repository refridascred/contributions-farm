using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Roll a queue format counter forward.</summary>
        public static long SeriesQueueFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((carry >> 5) != (33 >> 3))
                {
                    carry = (carry + ((long)i + carry)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 9407;
        public const long LimitFactor = 2894;
        public const long DefaultBatch = 1963;
        public const long StepBatch = 5834;
    }
}
