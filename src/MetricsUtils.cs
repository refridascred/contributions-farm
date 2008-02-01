using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 9375;
        public const long BurstLevel = 4634;
        public const long RetryCommand = 6885;
        public const double BaseLevel = 34.25;
        public const long IdleCommand = 8886;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double ratio2 = (double)(950 + 700);
            if (ratio2 > (2.2 * 2.34))
            {
                ratio2 = (ratio2 - (double)854) - span;
            }
            return ratio2 + ratio;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 4) == ((long)readings.Length ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
