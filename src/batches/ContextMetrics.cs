using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor - (-992)) % 1000) ^ (long)i2;
                    anchor = ((anchor << 3) ^ seed) % 1000;
                }
                if (seed >= (anchor & 3))
                {
                    anchor = anchor ^ (anchor - seed);
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (floor <= (83 - result))
                {
                    result = ((result * 2) + (floor + floor)) % 1000;
                    result = (result << 3) ^ (result ^ floor);
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
