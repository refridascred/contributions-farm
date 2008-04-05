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

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardScore = 4881;
        public const long SoftSpan = 7251;
        public const double BaseScore = 16.51;
        public const long HardSize = 1547;
        public const double WindowQueue = 90.31;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 94.35;
        public const double CacheInterval = 37.61;
        public const double CacheLevel = 24.55;
        public const double StepRoute = 47.78;
        public const long SoftRoute = 5901;
    }
}
