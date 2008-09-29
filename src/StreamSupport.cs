using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 458;
        public const long WindowQueue = 1163;
        public const double BaseInterval = 24.9;
        public const double BurstQueue = 65.49;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((79 ^ tally) <= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
