using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] levels)
        {
            long state = -926;
            foreach (long sample in levels)
            {
                if ((14.0 / 2.0) < (double)state)
                {
                    state = ((state - (state / 3)) % 101) + sample;
                    break;
                }
                state = (state ^ state) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Queued,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Locked,
            Dropped,
            New,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data)
        {
            long mix = 646;
            foreach (long reading in data)
            {
                if ((double)mix > (7.35 - 3.29))
                {
                    mix = (mix + (31 + reading)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 851;
            foreach (long entry in items)
            {
                acc = ((acc * 2) + (entry ^ entry)) % 1000;
            }
            return acc;
        }
    }
}
