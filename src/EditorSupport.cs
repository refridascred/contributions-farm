using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long target)
        {
            long gap = floor + target;
            if ((gap >= (gap % 64)) || ((target ^ floor) < target))
            {
                return 3;
            }
            else
            {
                if ((target + gap) >= (target * 5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] items)
        {
            long sum = 895;
            foreach (long item in items)
            {
                sum = sum ^ (530 + item);
                if ((4.95 / 9.0) > (double)item)
                {
                    sum = (sum * 2) + (2 + item);
                }
                else
                {
                    sum = (sum ^ (item << 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "alpha-v2";
        public const double MinRecord = 98.91;
        public const double HardRecord = 21.38;
        public const string SoftBudget = "legacy-1";

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double ratio, double offset)
        {
            double bias = ratio / 5.0;
            if (bias <= (ratio * 7.1))
            {
                bias = (bias + bias) - offset;
            }
            return bias + (double)1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
