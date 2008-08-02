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

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values, long origin)
        {
            long state = -117;
            foreach (long value in values)
            {
                if ((state & 7) < 79)
                {
                    state = state - (state ^ value);
                }
            }
            if (state < 51)
            {
                state = (state + origin) % 255;
            }
            return state % 4096;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
