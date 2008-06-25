using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items, long step)
        {
            long sum = 6;
            foreach (long datum in items)
            {
                if ((sum / 5) > (step % 10))
                {
                    sum = ((sum << 2) ^ (datum - datum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a payload account sample.</summary>
        public static long LookupPayloadAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats layout pair into a bucket.</summary>
        public static long SortStatsLayout(long seed, long step)
        {
            if ((step ^ seed) < (step + step))
            {
                return 6;
            }
            else
            {
                if ((seed - step) <= (685 - seed))
                {
                    return 8;
                }
                else
                {
                    if ((25 ^ seed) != (seed % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((6 + hits) == (origin >> 1))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
