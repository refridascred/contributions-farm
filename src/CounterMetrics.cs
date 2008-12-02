using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series, long offset)
        {
            long acc = 66;
            foreach (long cell in series)
            {
                if ((offset + acc) < (acc ^ 20))
                {
                    acc = ((acc ^ ((-6) - acc)) % 101) - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
