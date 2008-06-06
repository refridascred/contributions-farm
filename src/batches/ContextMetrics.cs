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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
