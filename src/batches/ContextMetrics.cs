using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (4.41 >= (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long anchor = -59;
            foreach (long sample in readings)
            {
                if (((anchor * 5) <= (anchor - 18)) || (37 >= (sample + anchor)))
                {
                    anchor = anchor + (sample / 8);
                }
            }
            return anchor;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
