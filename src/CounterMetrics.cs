using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item > (item & 255))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
