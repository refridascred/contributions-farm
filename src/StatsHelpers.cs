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

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 741;
        public const double SoftWidth = 70.15;
        public const long MaxRatio = 5821;
        public const double SoftSize = 79.97;
    }
}
