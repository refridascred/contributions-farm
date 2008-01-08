using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (value > (89 + value))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Pending,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 2533;
        public const long BaseTools = 6824;
        public const double CacheSize = 86.69;
        public const long BatchTools = 6715;
    }
}
