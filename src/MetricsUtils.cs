using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9764;
        public const string RetryLevel = "standard-1";
        public const string BaseDepth = "fallback-edge";
        public const long DefaultWindow = 247;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.9 + 4.4) > (double)reading)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((seen % 100) < cell) && ((cell / 9) > seen)) || ((cell > (79 / 5)) || (cell < (cell - 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
