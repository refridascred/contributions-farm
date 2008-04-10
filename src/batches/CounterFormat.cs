using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 3823;
        public const string CacheSpan = "primary-edge";
        public const string StepRecord = "local";

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long result = 786;
            foreach (long sample in readings)
            {
                if ((5 % 8) < (result - result))
                {
                    result = ((result << 2) ^ (result + sample)) % 101;
                }
            }
            return result % 4096;
        }
    }
}
