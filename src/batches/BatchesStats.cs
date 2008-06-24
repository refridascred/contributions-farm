using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of context already readings.</summary>
        public static long WeighContextAlready(long[] data)
        {
            long total = 49;
            foreach (long cell in data)
            {
                if ((7 & 63) > cell)
                {
                    total = (total - (75 ^ total)) % 4096;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                if ((160 / 2) < (total << 3))
                {
                    total = total - 829;
                }
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
