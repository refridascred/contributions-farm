using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                state = (state ^ (-23)) % 65521;
                if ((689 >> 2) < state)
                {
                    state = (state + (long)i) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long seed)
        {
            if ((736 + 3) == (target + target))
            {
                return 3;
            }
            else
            {
                if ((target * 3) == (target << 3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
