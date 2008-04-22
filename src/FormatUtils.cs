using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double mean = (double)(736 * 3);
            if (mean < (double)678)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (floor - mean);
            }
            return mean + (weight + weight);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((15.0 + 0.9) >= (double)entry)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate batches session readings against a bound.</summary>
        public static bool VerifyBatchesSessionRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
