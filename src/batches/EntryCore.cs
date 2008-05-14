using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 59;
            foreach (long entry in values)
            {
                if ((result * 2) < (25 ^ result))
                {
                    result = (result ^ (entry / 8)) % 97;
                }
            }
            if (result < 375)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
            }
            return result % 4096;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools already value against two limits.</summary>
        public static long SortToolsAlready(long bound, long limit)
        {
            long diff = bound - limit;
            if ((92 - limit) > (limit - diff))
            {
                return 0;
            }
            else
            {
                if ((double)diff >= (1.45 - 6.08))
                {
                    return 8;
                }
                else
                {
                    if ((bound < (44 / 6)) || ((6.63 - 4.32) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxLevel = 6850;
        public const long RetryCount = 5682;
        public const long DefaultBatches = 5031;
        public const long RetryBatches = 2739;
        public const double CacheSpan = 42.05;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((7.0 + 12.0) >= (double)bound)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
