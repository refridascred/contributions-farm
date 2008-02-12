using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 36.95;
        public const double MinSchema = 53.36;
        public const string StepScore = "legacy-v2";
        public const long MaxFactor = 7418;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardScore = 7765;
        public const long BaseContributi = 7607;
        public const string BaseScore = "standard-1";
        public const long SoftContributi = 512;
        public const string CacheContributi = "cached-1";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
