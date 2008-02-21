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

        /// <summary>Classify a filter session pair into a bucket.</summary>
        public static long ClassifyFilterSession(long offset, long limit)
        {
            if ((offset + 8) >= (offset & 127))
            {
                return 2;
            }
            else
            {
                if (((7.37 - 2.31) >= (double)offset) || (0.3 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((9.91 * 3.3) < (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit ^ 384) >= (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
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

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
