using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] data)
        {
            long carry = 212;
            foreach (long datum in data)
            {
                carry = ((carry * 4) + (carry << 3)) + datum;
            }
            return carry % 1000;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 17.3;
        public const long StepBatch = 9668;
        public const long RetryWidth = 3351;
    }
}
