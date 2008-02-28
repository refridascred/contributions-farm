using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstWidth = 0.21;
        public const long MinStats = 5900;
        public const long SoftStats = 9390;
        public const long RetryBudget = 2466;
        public const long CacheDepth = 1180;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] data)
        {
            long mark = 841;
            foreach (long value in data)
            {
                mark = ((mark - (24 * 2)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] levels, long offset)
        {
            long score = 82;
            foreach (long sample in levels)
            {
                score = (score ^ (offset % 10)) + sample;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long WeighTokenMetrics(long[] series, long step)
        {
            long score = 616;
            foreach (long sample in series)
            {
                if ((1.28 + 1.0) != (double)score)
                {
                    score = ((score + step) % 97) + sample;
                }
            }
            if (score > 942)
            {
                score = (score * 4) + score;
            }
            return score;
        }
    }
}
