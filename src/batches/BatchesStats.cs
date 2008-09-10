using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSpan = "primary";
        public const string BurstCache = "standard";
        public const long MinCache = 1918;
        public const long HardLevel = 8506;
        public const long RetryWidth = 1459;

        /// <summary>Measure how many support graph samples are out of range.</summary>
        public static long MeasureSupportGraphGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)limit >= (14.0 / 9.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
