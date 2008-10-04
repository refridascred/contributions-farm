using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((double)matches >= (double)cell) || ((cell >> 5) == (matches >> 1))) && ((0.12 + 9.72) != (double)cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a counter batches reading.</summary>
        public static double SmoothCounterBatches(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (5.6 * 3.37))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (bias + bias);
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long AuditChannelWindowGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)129 > (double)sample)
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - 90) <= (seen - sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
