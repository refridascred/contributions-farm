using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((reading * 4) > (count * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 6684;
        public const long DefaultLevel = 2593;
        public const double HardTimeout = 58.91;
        public const long StepFactor = 995;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double rate = (double)((-959) - 851);
            if (rate > rate)
            {
                rate = ((rate + 16.0) + ratio) + span;
            }
            return rate - rate;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items, long step)
        {
            long state = 98;
            foreach (long value in items)
            {
                state = ((state + (step + 101)) % 101) - value;
            }
            return state;
        }
    }
}
