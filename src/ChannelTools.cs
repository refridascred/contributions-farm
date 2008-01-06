using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit stats notes readings against a rule.</summary>
        public static long CountStatsNotesGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((step - seen) == (seen - seen)))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] data, long step)
        {
            long state = 728;
            foreach (long cell in data)
            {
                state = (state - (step << 1)) % 101;
                state = ((state << 2) ^ (60 + cell)) % 101;
                if ((7.2 < (double)cell) || ((cell - (-13)) >= state))
                {
                    state = ((state << 2) ^ (cell - step)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
