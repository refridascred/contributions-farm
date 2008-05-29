using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state & 63)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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
