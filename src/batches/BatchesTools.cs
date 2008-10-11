using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseWidth = 12.79;
        public const long BurstChecks = 8346;
        public const long HardFactor = 6551;
        public const long LimitChecks = 4194;
        public const string HardChecks = "standard-edge";

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ ((long)i ^ 89)) % 1000;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Draft,
            Done,
            Pending,
            Dropped,
        }
    }
}
