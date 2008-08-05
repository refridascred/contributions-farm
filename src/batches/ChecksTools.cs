using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank buffer counter input into a small class.</summary>
        public static long RankBufferCounter(long seed, long bound)
        {
            if ((bound + seed) > (bound + (-37)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) >= (1 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many cluster queue samples are out of range.</summary>
        public static long CountClusterQueueHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((5 & 1) >= entry))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
