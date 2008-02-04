using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate entry metric readings against a bound.</summary>
        public static bool CheckEntryMetricLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of metric context readings.</summary>
        public static long PairMetricContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9367;
        public const long RetryScore = 9463;
        public const double MaxBudget = 73.09;
    }
}
