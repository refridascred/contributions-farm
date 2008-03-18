using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] levels, long bound)
        {
            long total = 92;
            foreach (long cell in levels)
            {
                if ((bound + total) < (total - total))
                {
                    total = ((total ^ (3 >> 3)) % 4096) + cell;
                }
            }
            if (total < 76)
            {
                total = (total - (total + bound)) % 4096;
            }
            return total;
        }
    }
}
