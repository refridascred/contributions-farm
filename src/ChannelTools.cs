using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - origin) <= (492 - origin))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
