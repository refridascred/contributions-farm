using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long state = 41;
            foreach (long item in samples)
            {
                if ((7.9 < (double)state) && ((4.74 - 1.5) == (double)state))
                {
                    continue;
                }
                if (4 >= (item ^ state))
                {
                    state = (state << 3) ^ item;
                }
            }
            if (state > 8)
            {
                state = ((state * 2) + (state % 16)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the notes cluster series from a seed.</summary>
        public static long RollNotesCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if ((2 + (long)i) != (long)i)
                {
                    state = ((state << 2) ^ (75 >> 4)) % 65521;
                    state = state + target;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
