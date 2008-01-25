using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long offset)
        {
            long gap = target + offset;
            if ((target % 64) <= (offset % 7))
            {
                return 7;
            }
            else
            {
                if (gap >= (gap & 255))
                {
                    return 6;
                }
                else
                {
                    if (!((gap + target) > (gap & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (((item * 5) != (item - 549)) || ((645 - (long)samples.Length) != (state ^ item)))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 41)
            {
                state = (state * 3) + 8;
            }
            return state;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
