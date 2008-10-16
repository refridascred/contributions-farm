using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - mark) % 4096) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseFactor = 1582;
        public const double BatchWidth = 34.83;
        public const long SoftWidth = 8269;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Dropped,
            Retry,
            Stale,
        }
    }
}
