using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultRatio = 8641;
        public const long StepBudget = 2612;
        public const string BurstSession = "legacy-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7528;
        public const string LimitLevel = "local-v2";
        public const long WindowPayload = 2609;
        public const long IdlePayload = 4324;

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                if ((item + sum) > item)
                {
                    sum = (sum + item) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8538;
        public const long StepLevel = 77;
        public const double CacheContext = 48.05;
        public const long BurstRatio = 9707;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (tally >= ((long)series.Length + tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
