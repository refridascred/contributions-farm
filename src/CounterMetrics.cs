using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first filter counter entry that matches the target.</summary>
        public static long SeekFilterCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(seen >= 54))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed <= (7.53 - 2.26))
                {
                    state = ((state << 3) ^ (long)i) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
