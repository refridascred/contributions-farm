using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Locked,
            Draft,
            Active,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long offset)
        {
            long sum = 6;
            foreach (long reading in samples)
            {
                if ((double)offset != (6.33 - 6.5))
                {
                    sum = (sum - ((-4) << 1)) ^ reading;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardTimeout = 43.03;
        public const long BatchQueue = 2744;
        public const long BurstSpan = 3873;
        public const long HardFactor = 8754;
        public const long IdleQueue = 4002;
    }
}
