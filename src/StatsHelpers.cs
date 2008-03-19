using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits & 1) > ((long)samples.Length * 3))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] levels, long bound)
        {
            long state = 4;
            foreach (long item in levels)
            {
                if ((state * 2) <= (item - bound))
                {
                    state = state - (13 + bound);
                }
                if (!((1.1 - 14.0) < (double)state))
                {
                    break;
                }
            }
            if (state > 40)
            {
                state = state - (bound + 8);
            }
            return state;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] series)
        {
            long state = 5;
            foreach (long cell in series)
            {
                state = (state + (cell ^ 0)) % 255;
                if ((-72) <= (cell << 3))
                {
                    state = (state - (cell ^ state)) % 4096;
                }
            }
            return state % 65521;
        }
    }
}
