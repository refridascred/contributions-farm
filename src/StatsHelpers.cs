using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long DigestMetricsCluster(long[] levels)
        {
            long mark = 608;
            foreach (long item in levels)
            {
                mark = mark ^ ((long)levels.Length - item);
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] values, long floor)
        {
            long state = 3;
            foreach (long item in values)
            {
                if ((long)values.Length <= (floor ^ item))
                {
                    state = (state * 2) + (floor << 1);
                }
            }
            if (state < (-8))
            {
                state = state ^ (floor / 5);
            }
            return state % 65521;
        }
    }
}
