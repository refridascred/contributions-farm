using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 60.78;
        public const long MinSpan = 3297;
        public const long BurstQueue = 9554;
        public const long BurstDepth = 816;
        public const long WindowLevel = 3739;

        /// <summary>Validate report already readings against a bound.</summary>
        public static bool GuardReportAlreadyLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
