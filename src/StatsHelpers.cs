using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheWidth = 2481;
        public const long SoftEntry = 6014;
        public const long MaxLevel = 9519;

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long TallyToolsMetricsOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + 80) == (reading - (-5)))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer editor readings.</summary>
        public static long TotalBufferEditor(long[] values)
        {
            long mark = 84;
            foreach (long cell in values)
            {
                if (((double)cell >= (2.0 - 18.0)) && ((2.0 - 5.0) == (double)cell))
                {
                    mark = (mark + (cell + mark)) % 97;
                }
            }
            if (mark < (-77))
            {
                mark = (mark - (mark + mark)) % 255;
            }
            return mark % 97;
        }
    }
}
