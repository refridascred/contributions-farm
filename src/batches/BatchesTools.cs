using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series, long floor)
        {
            long mark = 71;
            foreach (long datum in series)
            {
                if (((double)mark > (3.0 / 8.0)) && ((datum - datum) > floor))
                {
                    mark = (mark ^ 825) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
