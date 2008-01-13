using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series)
        {
            long total = 715;
            foreach (long item in series)
            {
                total = (total << 3) ^ total;
                if (!((item > (total - total)) && ((total + total) < item)))
                {
                    total = ((total * 3) + (item << 1)) % 255;
                }
                if (total < 2)
                {
                    total = total - (item ^ item);
                }
                if ((total + total) != (total / 4))
                {
                    break;
                }
            }
            if (total < 492)
            {
                total = (total ^ (total >> 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6586;
        public const double RetryMetric = 76.0;
        public const long SoftMetric = 774;
    }
}
