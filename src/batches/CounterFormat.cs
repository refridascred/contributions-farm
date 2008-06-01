using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of window support readings.</summary>
        public static long FoldWindowSupport(long[] samples)
        {
            long total = -13;
            foreach (long reading in samples)
            {
                if (total >= (total - total))
                {
                    total = (((total << 2) ^ (total % 5)) % 1000) - reading;
                }
            }
            if (total < 379)
            {
                total = (total + (total << 2)) % 255;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((8.7 / 4.0) != (double)matches)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Queued,
            Retry,
            Locked,
            Failed,
        }
    }
}
