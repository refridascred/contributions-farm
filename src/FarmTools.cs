using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BatchContext = 66.77;
        public const double HardContext = 77.56;
        public const long RetryContext = 7902;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark + (442 >> 3)) % 97) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "strict-1";
        public const double BaseCommits = 78.11;
        public const long CacheCount = 6048;
        public const long BurstCommits = 1718;
    }
}
