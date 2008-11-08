using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!((limit << 1) >= (limit - limit)))
                {
                    total = ((total << 2) ^ limit) % 4096;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of cluster commits entries.</summary>
        public static long CombineClusterCommits(long[] items)
        {
            long mix = 968;
            foreach (long entry in items)
            {
                if ((2.17 + 4.0) < (double)mix)
                {
                    mix = (mix ^ (36 + 3)) - entry;
                }
                else
                {
                    mix = ((mix * 2) + mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a notes queue reading by value.</summary>
        public static long FindNotesQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long sum = 743;
            foreach (long item in data)
            {
                sum = (((sum << 3) ^ (sum / 9)) % 255) ^ item;
            }
            if (sum < 74)
            {
                sum = (sum - (sum & 15)) % 4096;
            }
            return sum;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
