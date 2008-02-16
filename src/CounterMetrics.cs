using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if (((double)step >= (10.0 + 2.0)) || ((double)(long)i == (6.69 + 3.47)))
                {
                    continue;
                }
                mix = (mix ^ (step + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of filter command entries.</summary>
        public static long CombineFilterCommand(long[] series, long origin)
        {
            long state = 639;
            foreach (long item in series)
            {
                state = ((state * 3) + origin) % 255;
                if (((item - (-5)) <= (item & 31)) || ((origin + item) > item))
                {
                    state = (state - (state + item)) % 255;
                }
                else
                {
                    state = (state * 4) + (item & 3);
                }
                state = state ^ (item % 12);
            }
            if (state > 919)
            {
                state = (state * 2) + (origin + origin);
            }
            return state;
        }
    }
}
