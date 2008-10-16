using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ (target ^ (long)i);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }
    }
}
