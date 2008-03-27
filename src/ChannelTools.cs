using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!(cell < (859 + cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data, long bound)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                if ((double)(long)data.Length == (double)bound)
                {
                    anchor = (((anchor << 2) ^ (195 >> 3)) % 4096) + item;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 2) ^ ((long)data.Length / 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
