using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] items)
        {
            long acc = 7;
            foreach (long sample in items)
            {
                acc = acc ^ (acc * 4);
                acc = acc - (sample + sample);
                if ((6.0 + 6.81) >= (double)sample)
                {
                    acc = (acc ^ (sample ^ acc)) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                state = (state - datum) % 255;
            }
            if (state > (-97))
            {
                state = (state - (7 >> 2)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long seed)
        {
            long carry = 96;
            foreach (long sample in data)
            {
                carry = (carry - (seed & 31)) ^ sample;
            }
            return carry;
        }
    }
}
