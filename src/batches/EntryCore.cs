using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two metrics metric measurements.</summary>
        public static double SmoothMetricsMetric(double weight, double bias)
        {
            double bias2 = (double)(16 ^ 12);
            if (bias2 >= (double)7)
            {
                bias2 = (bias2 - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - (double)8;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 7707;
        public const long BatchFarm = 6658;
        public const double BurstBudget = 22.53;
        public const long IdleCount = 5956;
        public const long MaxFarm = 3247;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context support value from a seed.</summary>
        public static long IterateContextSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public double Count { get; set; }
        }
    }
}
