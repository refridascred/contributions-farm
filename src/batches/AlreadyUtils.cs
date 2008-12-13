using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSpan = 2841;
        public const long DefaultInterval = 4571;
        public const string BurstWindow = "open-v2";
        public const long StepBudget = 7760;
        public const long CacheSize = 2096;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)origin > (0.1 * 4.9))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Idle,
            Queued,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many buffer order samples are out of range.</summary>
        public static long CountBufferOrderGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (11.0 >= (double)count)
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
