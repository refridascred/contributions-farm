using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 6530;
        public const long CacheNotes = 2645;
        public const long CacheFactor = 7826;
        public const long WindowNotes = 5730;
        public const string IdleSize = "primary-1";

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double rate = floor / 4.0;
            return (rate + (9.56 / 8.0)) + bias;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 65.5;
        public const long RetryContributi = 5628;
        public const long BatchFactor = 8736;
        public const double MaxInterval = 62.82;
        public const long WindowDepth = 1031;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long target, long target2)
        {
            if ((target2 * 3) < (target << 3))
            {
                return 2;
            }
            else
            {
                if ((double)target > 7.4)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
