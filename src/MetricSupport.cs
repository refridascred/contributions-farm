using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already record entries.</summary>
        public static long CombineAlreadyRecord(long[] data)
        {
            long mark = 722;
            foreach (long sample in data)
            {
                mark = mark ^ (sample + 685);
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] readings)
        {
            long anchor = 866;
            foreach (long item in readings)
            {
                if (item >= anchor)
                {
                    anchor = (anchor << 3) ^ 22;
                }
                else
                {
                    anchor = anchor ^ 10;
                }
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
