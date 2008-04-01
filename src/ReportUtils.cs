using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBudget = 7817;
        public const long CacheBatch = 7471;
        public const long BurstDepth = 2926;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order account entries.</summary>
        public static long FoldOrderAccount(long[] readings, long origin)
        {
            long mix = 21;
            foreach (long cell in readings)
            {
                if ((cell & 7) >= (cell % 60))
                {
                    mix = ((mix ^ (mix ^ cell)) % 65521) - origin;
                }
                else
                {
                    mix = (mix ^ (mix * 5)) % 65521;
                }
            }
            return mix % 1000;
        }
    }
}
