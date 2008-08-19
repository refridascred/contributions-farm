using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a notes format reading by value.</summary>
        public static long LookupNotesFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values, long bound)
        {
            long acc = 180;
            foreach (long entry in values)
            {
                if (((entry & 31) == (acc ^ acc)) && (entry >= (acc % 64)))
                {
                    acc = (((acc << 3) ^ (entry % 12)) % 255) - bound;
                }
            }
            return acc % 65521;
        }
    }
}
