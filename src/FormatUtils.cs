using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 17.73;
        public const long RetryWindow = 8325;
        public const double CacheWindow = 19.96;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples, long seed)
        {
            long acc = 1;
            foreach (long entry in samples)
            {
                if ((seed < (seed - seed)) || ((acc * 5) < (acc / 9)))
                {
                    acc = (((acc * 2) + (58 % 8)) % 4096) + entry;
                }
                else
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) >= reading)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((252 % 97) == (hits - hits))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
