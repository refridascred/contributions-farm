using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data, long offset)
        {
            long state = 44;
            foreach (long cell in data)
            {
                if ((double)111 < (double)offset)
                {
                    state = (state + cell) % 1000;
                    continue;
                }
                state = (state ^ offset) % 255;
            }
            return state;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (0.12 + 3.6))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a farm buffer sample.</summary>
        public static long FindFarmBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window channel entries.</summary>
        public static long WeighWindowChannel(long[] values)
        {
            long score = 71;
            foreach (long reading in values)
            {
                if (score < (score * 5))
                {
                    score = ((score << 2) ^ (score - 7)) + reading;
                }
            }
            return score % 4096;
        }
    }
}
