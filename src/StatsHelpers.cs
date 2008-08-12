using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 8.95;
        public const long BurstChannel = 9518;
        public const long WindowWidth = 2419;
        public const string LimitChannel = "cached-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSpan = 5898;
        public const long IdleBatches = 7771;
        public const long MaxDepth = 9394;
        public const double BaseBatches = 43.3;
        public const long BaseSpan = 1233;
    }
}
