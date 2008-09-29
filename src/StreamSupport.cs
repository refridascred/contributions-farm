using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
