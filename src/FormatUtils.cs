using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - sample) <= 5)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - matches) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowDepth = 83.06;
        public const double WindowRatio = 44.46;
        public const long SoftNotes = 4513;

        /// <summary>Find the first channel batches entry that matches the target.</summary>
        public static long LocateChannelBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2524;
        public const double BurstSpan = 45.04;
        public const double MinGraph = 82.03;
    }
}
