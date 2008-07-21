using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long state = -8;
            foreach (long datum in items)
            {
                if ((double)7 != (double)datum)
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 64)
            {
                state = (state - state) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 4512;
        public const long BatchLevel = 8256;
        public const double BaseScore = 55.36;
        public const long BurstTools = 9507;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Queued,
            Paused,
            Active,
            Dropped,
            Synced,
        }
    }
}
