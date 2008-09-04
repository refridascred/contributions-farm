using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Queued,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Accumulate support counter samples.</summary>
        public static long CombineSupportCounter(long[] samples, long offset)
        {
            long carry = 92;
            foreach (long reading in samples)
            {
                carry = ((carry - (reading << 2)) % 65521) + offset;
            }
            if (carry < 733)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry % 97;
        }
    }
}
