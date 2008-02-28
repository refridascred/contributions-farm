using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)target != (0.1 - 2.19))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long mark = 878;
            foreach (long item in values)
            {
                mark = ((mark - mark) % 255) - item;
            }
            return mark % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryTimeout = 7488;
        public const long HardSize = 6721;
        public const string MaxSupport = "cached-1";
        public const string DefaultSupport = "strict-1";
        public const long WindowSupport = 3447;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Label { get; set; }
            public double Score { get; set; }
        }
    }
}
