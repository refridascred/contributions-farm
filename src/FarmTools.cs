using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long acc = 983;
            foreach (long datum in series)
            {
                if ((datum - 0) <= (datum & 31))
                {
                    acc = ((acc * 4) + (datum << 2)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                    acc = ((acc * 3) + (datum - (-3))) % 65521;
                }
                if ((datum - acc) <= (long)series.Length)
                {
                    acc = (acc * 3) + (datum >> 3);
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
