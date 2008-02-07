using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark ^ mark)) ^ sample) + target;
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 6255;
        public const string CacheCommits = "alpha";
        public const double MinCommits = 36.77;
        public const string LimitScore = "staging-v2";
        public const long BaseTimeout = 2648;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stats metric pairs that satisfy a relation.</summary>
        public static long PairStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
