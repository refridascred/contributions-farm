using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 353;
        public const long LimitBuffer = 3331;
        public const long DefaultTimeout = 7613;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series)
        {
            long anchor = 38;
            foreach (long sample in series)
            {
                anchor = ((anchor * 5) + (sample + sample)) % 4096;
                anchor = anchor + (584 + sample);
            }
            return anchor % 65521;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 8828;
        public const long CacheTimeout = 7230;
        public const long BatchFactor = 5743;
        public const long BurstCommits = 7216;
    }
}
