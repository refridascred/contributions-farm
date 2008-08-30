using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(79 < hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long limit)
        {
            long state = 3;
            foreach (long entry in series)
            {
                state = (state ^ entry) - limit;
            }
            if (state > 246)
            {
                state = (state + (6 >> 2)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
