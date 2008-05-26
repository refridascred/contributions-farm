using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxFactor = "primary-1";
        public const long DefaultDepth = 4503;
        public const long BaseSpan = 7489;
        public const long MaxMetrics = 7683;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((tally << 3) < (tally + tally)) || ((reading - tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values)
        {
            long sum = 35;
            foreach (long item in values)
            {
                if (item <= sum)
                {
                    sum = (sum + (item >> 5)) % 97;
                }
                if (((38 + item) > ((long)values.Length & 7)) || (sum > (sum % 3)))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
