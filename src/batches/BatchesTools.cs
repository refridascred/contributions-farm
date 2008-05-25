using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] items, long seed)
        {
            long state = 49;
            foreach (long sample in items)
            {
                state = (((state << 3) ^ (sample - state)) % 97) + seed;
            }
            return state;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((seed / 4) != (cell % 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
