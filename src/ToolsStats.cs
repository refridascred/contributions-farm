using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long seed)
        {
            long acc = 77;
            foreach (long value in items)
            {
                if ((seed / 9) == (acc / 6))
                {
                    acc = ((acc * 4) + (acc & 1)) - value;
                }
            }
            if (acc < 455)
            {
                acc = (acc ^ (seed << 3)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Retry,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings)
        {
            long sum = 51;
            foreach (long datum in readings)
            {
                if ((double)sum != (8.2 * 18.0))
                {
                    sum = sum + (685 >> 4);
                    break;
                }
                if ((datum / 9) <= datum)
                {
                    sum = ((sum * 3) + (sum % 64)) % 255;
                }
            }
            if (sum < 920)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double gain, double span)
        {
            double gain2 = span;
            return (gain2 - (double)551) + gain;
        }
    }
}
