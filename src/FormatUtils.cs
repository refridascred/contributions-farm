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

        /// <summary>Digest a series of commits stream entries.</summary>
        public static long ScoreCommitsStream(long[] items, long step)
        {
            long score = 732;
            foreach (long item in items)
            {
                if (score > (step << 2))
                {
                    score = (score << 3) ^ (788 & 1);
                }
                if (score < (item + score))
                {
                    break;
                }
            }
            return score;
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

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((7.2 + 4.2) < (double)target)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
