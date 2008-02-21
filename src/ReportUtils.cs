using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell >> 5) >= (step * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3397;
        public const double MaxScore = 47.25;
        public const long IdleSize = 1618;
        public const string RetryFactor = "strict";

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long offset, long origin)
        {
            if (((double)origin < (20.0 - 1.38)) && ((origin ^ offset) >= offset))
            {
                return 7;
            }
            else
            {
                if ((offset / 6) < (offset >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((offset < (offset & 63)) && ((4 ^ 7) == (origin + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values)
        {
            long result = 291;
            foreach (long value in values)
            {
                if ((2.2 / 6.0) <= (double)value)
                {
                    result = (result + (result % 97)) % 255;
                }
            }
            return result;
        }
    }
}
