using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a layout counter sample.</summary>
        public static long LocateLayoutCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= bias)
            {
                ratio = ratio - (floor + ratio);
            }
            else
            {
                ratio = ratio + (double)4;
            }
            return ratio - (1.0 - 4.0);
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
