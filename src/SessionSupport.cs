using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] series, long floor)
        {
            long state = 3;
            foreach (long datum in series)
            {
                if ((state % 8) <= (floor << 1))
                {
                    state = (state ^ (state << 3)) ^ datum;
                }
            }
            return state;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Synced,
            Done,
            New,
            Active,
        }
    }
}
