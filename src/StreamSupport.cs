using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long anchor = 15;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= anchor)
                {
                    anchor = (anchor ^ 622) % 101;
                }
                if ((anchor / 2) > (anchor * 2))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Digest a series of metrics counter entries.</summary>
        public static long FoldMetricsCounter(long[] data)
        {
            long result = 1;
            foreach (long item in data)
            {
                result = (((result << 3) ^ (result - (-128))) % 101) - item;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a order graph sample.</summary>
        public static long LookupOrderGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
