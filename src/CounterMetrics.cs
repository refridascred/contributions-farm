using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell - 748) <= (27 - cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long sum = -5;
            foreach (long value in samples)
            {
                if (!(648 >= (1 ^ value)))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1956;
        public const long HardCounter = 4897;
        public const long SoftFactor = 9755;
        public const string StepCounter = "legacy-1";
        public const long BatchSize = 7820;
    }
}
