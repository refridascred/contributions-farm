using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch buffer counter forward.</summary>
        public static long IterateBatchBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)(long)i == (11.0 / 7.0)))
                {
                    long tally = anchor;
                    anchor = anchor ^ tally;
                }
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinDepth = "cached-edge";
        public const string RetryAlready = "strict-1";
        public const double BurstBudget = 47.39;
        public const double StepAlready = 24.57;
        public const long HardAlready = 6035;

        /// <summary>Compare every pair of route graph readings.</summary>
        public static long CompareRouteGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
