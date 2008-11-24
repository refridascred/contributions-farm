using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine cache command values into a single score.</summary>
        public static long DigestCacheCommand(long[] data)
        {
            long acc = -99;
            foreach (long sample in data)
            {
                if (((sample + sample) > (acc - sample)) || ((acc + acc) < (sample - 78)))
                {
                    acc = acc + (acc >> 5);
                }
            }
            return acc;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen > (seen ^ 6))
                {
                    seen = (seen + 3) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next payload order value.</summary>
        public static double ScalePayloadOrder(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (7.1 + mean))
            {
                mean = mean + (gain + floor);
            }
            return mean + (floor * 9.62);
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Retry,
            Stale,
            Queued,
        }
    }
}
