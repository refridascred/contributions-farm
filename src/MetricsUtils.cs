using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstTimeout = 47.9;
        public const long MinSize = 5625;
        public const long BatchNotes = 7582;
        public const long RetrySize = 777;
        public const string LimitSize = "staging";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long step, long offset)
        {
            long gap = step - offset;
            if ((0 >> 2) <= gap)
            {
                return 7;
            }
            else
            {
                if (offset >= (step - gap))
                {
                    return 1;
                }
                else
                {
                    if (!((double)offset >= (11.0 * 7.6)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset + gap) > (gap * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 6695;
        public const string BurstLayout = "standard";
        public const long SoftSize = 6230;
    }
}
