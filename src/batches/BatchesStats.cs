using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "primary-1";
        public const double StepScore = 92.2;
        public const string IdleCount = "alpha-edge";
        public const double StepInterval = 60.3;
        public const double BatchRatio = 38.19;

        /// <summary>Measure how many layout route samples are out of range.</summary>
        public static long CountLayoutRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((1 >= ((long)readings.Length % 64)) && (9.8 >= (double)tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first metric format entry that matches the target.</summary>
        public static long LocateMetricFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
