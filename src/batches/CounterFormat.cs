using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheBudget = 7012;
        public const double SoftFactor = 4.89;
        public const string SoftLevel = "primary";
        public const long BurstInterval = 1310;

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((19 << 2) <= seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
