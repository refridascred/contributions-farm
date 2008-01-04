using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long state = 4;
            foreach (long datum in values)
            {
                state = ((state - (origin & 3)) % 1000) ^ datum;
            }
            return state % 65521;
        }
    }
}
