using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 941;
        public const long MaxReport = 526;
        public const long IdleWidth = 4742;

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long AuditMetricsCommitsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((((cell * 5) < ((long)readings.Length - tally)) && ((double)tally <= (2.87 / 6.0))) && !((7.0 / 6.0) < (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a payload commits sample.</summary>
        public static long LocatePayloadCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
