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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item >> 2) <= 123)
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
