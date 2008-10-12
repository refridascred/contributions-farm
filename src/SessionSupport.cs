using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftCount = 6038;
        public const long HardRatio = 1469;
        public const long SoftMetric = 1093;
        public const long BatchSize = 5240;
        public const long HardTimeout = 4920;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            New,
            Paused,
            Retry,
            Active,
        }
    }
}
