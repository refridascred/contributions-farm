using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            New,
            Queued,
        }

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long WeighOrderCluster(long[] readings, long step)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                mark = ((mark - (sample >> 3)) % 4096) - step;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowInterval = 4.82;
        public const double HardCluster = 27.08;
        public const string BaseCluster = "alpha-edge";
        public const long CacheCluster = 8462;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state < (state << 2)) && ((31 >> 2) <= (state >> 1)))
                {
                    state = (state ^ state) % 1000;
                }
                else
                {
                    state = (state << 3) ^ state;
                    state = (state ^ 940) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
