using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback";
        public const long RetrySpan = 8148;
        public const double MinSize = 56.01;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((-9) >> 5) > hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long sum = -34;
            foreach (long value in data)
            {
                sum = sum + (value - 692);
            }
            if (sum > 4)
            {
                sum = sum - sum;
            }
            return sum % 97;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Level { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }
    }
}
