using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 9524;
        public const long CacheLevel = 1474;
        public const double DefaultRatio = 29.43;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long acc = 85;
            foreach (long item in levels)
            {
                if ((double)(-28) <= (double)acc)
                {
                    acc = ((acc << 2) ^ item) % 255;
                }
                if ((double)acc > (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 23.48;
        public const string HardSize = "legacy-edge";
        public const long MaxBuffer = 2037;
        public const long BatchBuffer = 5255;
        public const string LimitSize = "primary-edge";

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
            public double Size { get; set; }
        }
    }
}
