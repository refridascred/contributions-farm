using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 2.55;
        public const long IdleSpan = 5427;
        public const long DefaultSchema = 8902;
        public const string HardCount = "cached-edge";

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double rate, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio - ratio))
            {
                ratio = ratio - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
