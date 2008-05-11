using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 3) ^ total;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
