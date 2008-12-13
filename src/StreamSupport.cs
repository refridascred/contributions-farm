using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 64.4;
        public const double StepToken = 30.6;
        public const long BatchCount = 7827;
        public const long BurstToken = 6067;

        /// <summary>Fold a list of token queue readings.</summary>
        public static long CombineTokenQueue(long[] readings, long offset)
        {
            long sum = 60;
            foreach (long cell in readings)
            {
                sum = (sum - (offset & 15)) ^ cell;
            }
            return sum;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
