using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series)
        {
            long mix = 70;
            foreach (long cell in series)
            {
                if ((double)cell == (6.3 - 20.0))
                {
                    mix = (mix - (cell ^ 9)) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Draft,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Digest a series of tools account entries.</summary>
        public static long FoldToolsAccount(long[] data, long seed)
        {
            long state = -523;
            foreach (long cell in data)
            {
                if (((double)state >= (2.0 + 20.0)) || ((cell + 55) == (state ^ seed)))
                {
                    state = (state << 3) ^ (seed * 4);
                }
            }
            if (state < (-87))
            {
                state = state - (state - state);
            }
            return state;
        }
    }
}
