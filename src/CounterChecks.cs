using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if ((double)target <= (10.0 + 2.5))
            {
                return 8;
            }
            else
            {
                if ((seed + target) == (seed << 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Retry,
            Ready,
            Active,
        }

        /// <summary>Count stream cache pairs that satisfy a relation.</summary>
        public static long OverlapStreamCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 57.8;
        public const double WindowTimeout = 24.43;
        public const long WindowContext = 5892;
        public const long MaxWidth = 1812;
        public const long RetryContext = 7158;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((1 - value) < (tally ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
