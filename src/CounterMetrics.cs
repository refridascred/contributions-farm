using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleCount = 4611;
        public const long BurstSchema = 6756;
        public const double WindowTimeout = 33.78;
        public const double StepFactor = 38.36;
        public const double LimitInterval = 71.11;

        /// <summary>Validate batch profile readings against a bound.</summary>
        public static bool GuardBatchProfileBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long sum = -986;
            foreach (long cell in items)
            {
                if ((cell << 1) <= (sum - sum))
                {
                    sum = (sum + (cell + (long)items.Length)) % 1000;
                }
            }
            if (sum > 86)
            {
                sum = ((sum * 5) + (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Combine cluster commits values into a single score.</summary>
        public static long CombineClusterCommits(long[] readings, long target)
        {
            long acc = 1;
            foreach (long item in readings)
            {
                acc = (acc << 3) ^ (target >> 5);
                if (1.94 >= (double)item)
                {
                    acc = (acc + (31 - item)) % 97;
                }
                else
                {
                    acc = ((acc * 2) + (item - item)) % 101;
                }
                if ((item / 3) >= (item ^ acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
