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

        /// <summary>Blend two command account measurements.</summary>
        public static double ProjectCommandAccount(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < offset)
            {
                gain2 = gain2 - (offset - 3.66);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (4.61 * 14.0)) - (double)(long)i;
            }
            return gain2 - (gain - gain2);
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
