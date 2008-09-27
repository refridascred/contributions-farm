using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            New,
            Active,
            Stale,
            Idle,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
