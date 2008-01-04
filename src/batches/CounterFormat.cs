using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "staging-edge";
        public const long StepRoute = 4608;
        public const long CacheSize = 2919;
        public const double CacheLevel = 82.36;
        public const long DefaultRoute = 5663;

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long CountContributiEntryMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)(long)data.Length >= (17.0 - 4.76)))
                {
                    tally = ((tally + 2) - cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2621;
        public const long BurstCount = 1751;
        public const string DefaultCount = "standard-edge";
        public const long RetryCache = 7177;
    }
}
