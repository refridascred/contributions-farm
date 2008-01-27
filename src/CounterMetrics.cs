using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseSpan = 133;
        public const string IdleProfile = "stable";
        public const long BatchProfile = 4794;
        public const string BurstProfile = "strict-v2";

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 9746;
        public const double WindowTools = 13.17;
        public const long IdleTools = 6394;
        public const long RetryTools = 637;

        /// <summary>Roll a stats order counter forward.</summary>
        public static long DeriveStatsOrder(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length <= (10.0 + 15.0))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }
    }
}
