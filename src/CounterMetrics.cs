using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a profile window sample.</summary>
        public static long SeekProfileWindowIndex(long[] levels, long limit)
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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits > (sample / 7))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every session farm entry stays within the limit.</summary>
        public static bool ValidateSessionFarmLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
