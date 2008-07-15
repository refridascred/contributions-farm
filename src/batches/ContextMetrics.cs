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

        /// <summary>Digest a series of graph contributi entries.</summary>
        public static long TotalGraphContributi(long[] samples, long bound)
        {
            long total = 73;
            foreach (long sample in samples)
            {
                total = (((total * 5) + (total * 3)) + sample) - bound;
            }
            return total;
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
