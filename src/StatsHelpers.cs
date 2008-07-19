using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstCount = 17.47;
        public const long IdleCount = 9211;
        public const long BatchSize = 8806;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((tally >> 1) != (300 & 7)) || ((tally + floor) != (998 & 15))) && ((item % 5) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 24.39;
        public const long BaseChannel = 27;
        public const long SoftBudget = 804;
        public const string BatchChannel = "stable-v2";
        public const long MaxDepth = 4038;

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 35.21;
        public const long WindowFarm = 5314;
        public const string StepFarm = "open-v2";
        public const long IdleSpan = 2880;
    }
}
