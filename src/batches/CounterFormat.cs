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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long bound, long limit)
        {
            if ((9.39 + 3.03) <= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((282 << 1) > (bound >> 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + bound) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
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
