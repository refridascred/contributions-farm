using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((2.78 / 8.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ datum) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate order report readings against a bound.</summary>
        public static bool GuardOrderReportLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseTimeout = 724;
        public const long SoftLevel = 8559;
        public const double IdleAccount = 78.02;
        public const long HardAccount = 7610;
    }
}
