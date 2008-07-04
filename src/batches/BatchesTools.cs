using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] values)
        {
            long mix = 4;
            foreach (long reading in values)
            {
                if ((9.27 * 6.6) != (double)reading)
                {
                    mix = (mix ^ (8 ^ mix)) % 1000;
                }
            }
            if (mix < 9)
            {
                mix = (mix * 4) + (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values)
        {
            long state = -898;
            foreach (long item in values)
            {
                if (state <= (0 - state))
                {
                    state = (state - (item * 2)) % 97;
                }
                else
                {
                    state = (state - (item >> 4)) % 97;
                }
            }
            return state % 1000;
        }
    }
}
