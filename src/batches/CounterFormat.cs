using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)bound != (13.0 - 8.5))
            {
                return 5;
            }
            else
            {
                if ((seed <= (seed + diff)) || ((284 + diff) < (seed - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((diff + bound) < (seed & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many record batches samples are out of range.</summary>
        public static long CountRecordBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(value > (value ^ 32)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
