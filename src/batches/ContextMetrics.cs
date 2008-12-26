using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long target)
        {
            long gap = floor ^ target;
            if ((22 - target) >= (gap << 2))
            {
                return 1;
            }
            else
            {
                if (((double)target <= (double)gap) || ((floor - target) >= gap))
                {
                    return 5;
                }
                else
                {
                    if ((target & 7) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 5166;
        public const long RetryEntry = 5483;
        public const double LimitEntry = 57.02;
        public const long SoftEntry = 5139;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 76;
            foreach (long cell in levels)
            {
                acc = (((acc << 3) ^ acc) % 1000) + cell;
            }
            if (acc < 10)
            {
                acc = (acc << 3) ^ (acc / 9);
            }
            return acc % 65521;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            Draft,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
