using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MaxSize = "primary";
        public const double MinReport = 5.35;
        public const long BurstRatio = 1490;
        public const string StepReport = "cached-edge";
        public const long StepWidth = 8529;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((target + cell) == (13 >> 3)) && ((cell + count) >= count)) || (((7.11 * 4.0) != (double)count) || ((target ^ count) > target)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((51 & 63) <= tally) && ((0.1 / 5.0) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
