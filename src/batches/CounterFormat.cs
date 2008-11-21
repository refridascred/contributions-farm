using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinInterval = 849;
        public const double CacheAccount = 42.82;
        public const double BurstAccount = 65.07;
        public const string BaseSize = "cached-1";
        public const string SoftAccount = "strict-1";

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - (sum - offset);
                sum = (sum ^ (sum * 5)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = state + datum;
            }
            return state;
        }
    }
}
