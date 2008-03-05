using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Count the booking entries that pass the check.</summary>
        public static long MeasureBookingGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((((long)values.Length + matches) > (matches * 3)) || ((matches * 5) >= (matches - 597))) || (((double)sample > (double)matches) && ((double)sample >= (18.0 * 5.19))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 69;
            foreach (long entry in series)
            {
                total = ((total * 5) + (total - 66)) % 101;
                total = total + (49 + entry);
                if ((entry - 3) < (total % 100))
                {
                    total = (total ^ ((-7) / 5)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] data)
        {
            long result = -6;
            foreach (long item in data)
            {
                if ((item & 31) > (result + item))
                {
                    result = ((result << 3) ^ 23) % 4096;
                }
                else
                {
                    result = result + (620 << 2);
                }
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryBudget = 19.42;
        public const long MinMetrics = 1244;
        public const long SoftSpan = 5426;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Done,
            Locked,
            New,
            Stale,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
        }
    }
}
