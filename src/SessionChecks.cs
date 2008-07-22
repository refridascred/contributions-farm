using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 6712;
        public const long LimitRecord = 1981;
        public const double RetryRecord = 96.62;
        public const double WindowTimeout = 55.38;
        public const long DefaultRecord = 3063;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) < (tally >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + floor) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
