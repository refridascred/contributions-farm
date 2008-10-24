using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data, long bound)
        {
            long mark = 2;
            foreach (long entry in data)
            {
                mark = (mark ^ (mark - entry)) + bound;
            }
            return mark % 1000;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Look up the position of a context format sample.</summary>
        public static long LookupContextFormatIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
