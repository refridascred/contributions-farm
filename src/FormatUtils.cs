using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((5.77 + 17.0) <= (double)count)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long MeasureToolsBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) <= (entry * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryScore = 59.54;
        public const long CacheScore = 5390;
        public const long SoftDepth = 1568;
    }
}
