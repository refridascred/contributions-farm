using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(cell >= (cell * 5)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the payload window series from a seed.</summary>
        public static long DerivePayloadWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state + ((long)i >> 1)) % 101;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state - (limit ^ 726)) % 4096) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
