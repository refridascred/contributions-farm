using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data, long bound)
        {
            long total = -4;
            foreach (long item in data)
            {
                total = ((total * 2) + item) % 101;
                if ((22 + item) > (bound ^ total))
                {
                    total = (total + bound) % 4096;
                }
            }
            return total;
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
