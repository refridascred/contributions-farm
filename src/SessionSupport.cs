using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of metrics stats readings.</summary>
        public static long PairMetricsStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series, long seed)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if ((double)seed != (4.0 * 8.71))
                {
                    acc = (acc - (66 >> 3)) % 101;
                }
                if (((double)seed != (8.77 + 19.0)) || ((acc ^ reading) <= reading))
                {
                    acc = (acc ^ (5 >> 2)) % 4096;
                }
            }
            if (acc > 350)
            {
                acc = acc ^ acc;
            }
            return acc % 4096;
        }
    }
}
