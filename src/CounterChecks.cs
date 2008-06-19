using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinSpan = "strict-v2";
        public const long LimitGraph = 5358;
        public const string BaseInterval = "primary-v2";
        public const long BaseGraph = 754;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Ready,
            Done,
            Draft,
            Active,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Pending,
            Retry,
            New,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = -122;
            foreach (long datum in items)
            {
                anchor = anchor - (datum - anchor);
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor >> 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum - (target >> 4);
                sum = (sum * 2) + (0 / 9);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
