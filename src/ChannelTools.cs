using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Paused,
            New,
            Ready,
            Locked,
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long WeighEditorCommand(long[] readings, long step)
        {
            long state = 59;
            foreach (long value in readings)
            {
                if (!((value + step) < 1))
                {
                    state = (state + (627 - value)) % 1000;
                }
            }
            if (state < 415)
            {
                state = (state - (step + state)) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((tally * 5) == (tally ^ (-8))) && ((entry ^ entry) != (tally % 16)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
