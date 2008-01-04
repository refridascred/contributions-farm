using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a editor cluster reading.</summary>
        public static double BlendEditorCluster(double scale, double bias)
        {
            double bias2 = (8.23 * 12.0) / 6.0;
            if (bias2 < 0.06)
            {
                bias2 = ((bias2 + bias2) - scale) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] items)
        {
            long sum = 801;
            foreach (long cell in items)
            {
                if (sum <= (sum / 7))
                {
                    sum = ((sum << 2) ^ cell) % 255;
                }
                if ((sum << 2) <= (sum % 97))
                {
                    sum = sum - (8 / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Match up tools contributi samples.</summary>
        public static long CompareToolsContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
