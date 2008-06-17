using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] samples, long origin)
        {
            long acc = 66;
            foreach (long reading in samples)
            {
                if ((origin << 2) < (origin + reading))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + 157)) % 101;
                }
            }
            if (acc > 511)
            {
                acc = (acc * 2) + (acc << 2);
            }
            return acc % 97;
        }

        /// <summary>Grade a stream filter value against two limits.</summary>
        public static long RankStreamFilter(long target, long bound)
        {
            long gap = target + bound;
            if (((gap + bound) >= (bound * 2)) && ((double)bound < (1.0 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((double)target == (6.9 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((19.0 - 8.0) < (double)item)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample >= (seen - 24)) || ((double)seen > (2.2 + 4.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchBudget = 6727;
        public const long MaxSize = 666;
        public const double BatchGraph = 0.3;
        public const long BaseGraph = 7050;
        public const string CacheWidth = "cached-edge";

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
