using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long seed)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if ((double)seed < (double)mark)
                {
                    mark = (mark ^ (mark * 3)) % 101;
                }
                else
                {
                    mark = (mark - (mark + reading)) % 4096;
                }
            }
            if (mark > 81)
            {
                mark = (mark + (mark / 4)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
