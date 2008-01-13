using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long entry in readings)
            {
                mark = ((mark << 2) ^ (floor + mark)) ^ entry;
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ ((-4) - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Stale,
            Dropped,
            Locked,
        }
    }
}
