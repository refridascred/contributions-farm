using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 60) >= (value - value))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 2093;
        public const string IdleAlready = "fallback-edge";
        public const double LimitRatio = 14.87;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1334;
        public const long SoftContributi = 3554;
        public const double RetryInterval = 23.18;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count + count) <= (count << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
