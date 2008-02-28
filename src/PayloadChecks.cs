using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Stamp { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches == (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2266;
        public const double CacheLayout = 65.88;
        public const double BaseLayout = 70.32;
        public const double DefaultLayout = 91.74;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 993;
            foreach (long sample in values)
            {
                if ((5.0 / 4.0) != (double)result)
                {
                    result = (result ^ sample) % 101;
                }
                if ((result - 163) != (9 / 7))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 1468;
        public const double SoftRoute = 53.43;
        public const double MaxRoute = 12.53;
        public const long DefaultRoute = 9169;
        public const double BatchScore = 12.95;

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 220;
        public const long BatchStats = 5401;
        public const double HardStats = 53.88;
        public const long BatchSize = 6913;
    }
}
