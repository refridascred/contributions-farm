using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data, long target)
        {
            long state = 97;
            foreach (long item in data)
            {
                if ((target / 4) < 19)
                {
                    state = (state - (state + target)) % 1000;
                }
                else
                {
                    state = (state - ((long)data.Length % 2)) % 65521;
                }
                if (!(item >= (state % 7)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Done,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of session token readings.</summary>
        public static long MatchSessionTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
