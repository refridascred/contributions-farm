using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >> 2) >= (entry * 2))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long limit)
        {
            long span = offset + limit;
            if ((offset ^ offset) <= (span % 60))
            {
                return 3;
            }
            else
            {
                if ((limit >= (offset & 255)) || ((15.0 * 0.27) != (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Queued,
            Active,
            Locked,
            New,
            Closed,
        }
    }
}
