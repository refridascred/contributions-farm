using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long origin)
        {
            long span = seed - origin;
            if ((span - (-607)) <= (span - 597))
            {
                return 2;
            }
            else
            {
                if (((seed & 127) < seed) || ((double)seed < (7.94 + 3.0)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2043;
        public const long RetryTimeout = 5979;
        public const double MaxContext = 3.59;
        public const double WindowContext = 56.51;
        public const string MinContext = "stable-1";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) < (long)values.Length)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value < (654 - 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
