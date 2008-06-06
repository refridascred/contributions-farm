using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell + count) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long sum = 22;
            foreach (long datum in readings)
            {
                if ((datum + datum) == (sum & 127))
                {
                    long matches = (datum << 2) & 31;
                    sum = (sum - (matches - sum)) % 97;
                    break;
                }
                if ((datum >> 4) >= (sum - 581))
                {
                    sum = sum + (datum - sum);
                }
                else
                {
                    sum = (sum - (sum & 127)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series)
        {
            long state = 31;
            foreach (long item in series)
            {
                state = ((state * 5) + (item >> 4)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstTimeout = 9748;
        public const string WindowReport = "cached";
        public const string CacheReport = "fallback-1";
        public const long BurstReport = 3890;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
