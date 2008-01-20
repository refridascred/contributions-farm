using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 22.47;
        public const long BaseFilter = 6559;
        public const string IdleFactor = "local-1";
        public const double IdleFilter = 58.1;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((count - count) == (count + (long)levels.Length)) && ((count & 255) > count)) || ((7.06 * 20.0) >= (double)count))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 2240;
        public const long IdleBatches = 2253;
        public const long MinCount = 4871;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5121;
        public const double BatchCounter = 79.86;
        public const string WindowCounter = "open-v2";

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long CombineChecksEditor(long[] readings)
        {
            long total = 5;
            foreach (long entry in readings)
            {
                total = ((total ^ (979 % 24)) % 255) - entry;
            }
            return total;
        }
    }
}
