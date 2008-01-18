using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 536;
        public const string CacheSize = "fallback-edge";
        public const double MinTimeout = 60.78;
        public const double LimitBatches = 11.33;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)step < (3.2 - 3.9)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((limit >> 4) <= (count + datum)) || (limit > (8 - datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc * 5) + offset) % 101) ^ (long)i2;
                }
                acc = (acc + (acc << 1)) % 97;
                for (int i3 = 0; i3 < 3; i3++)
                {
                    acc = (((acc * 2) + (offset - 44)) % 65521) + (long)i3;
                    acc = (acc ^ ((long)i * 2)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
