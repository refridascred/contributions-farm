using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long state = 802;
            foreach (long datum in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = state ^ (datum / 2);
                    state = ((state * 5) + (35 + (long)i)) % 1000;
                }
                if (((datum + 413) != (datum + datum)) || ((double)7 > (double)state))
                {
                    state = (state * 5) + state;
                }
                if ((9.53 * 2.0) == (double)datum)
                {
                    break;
                }
            }
            if (state < 341)
            {
                state = ((state * 5) + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
