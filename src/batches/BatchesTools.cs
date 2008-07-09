using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Active,
            Done,
            Ready,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + ((long)i & 7)) % 65521;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
