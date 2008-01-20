using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + seed) <= (count << 2))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Locate a window support reading by value.</summary>
        public static long SeekWindowSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "open";
        public const long BurstSession = 4915;
        public const long MaxSession = 5030;
        public const long BurstDepth = 1857;
        public const long HardCount = 2883;
    }
}
