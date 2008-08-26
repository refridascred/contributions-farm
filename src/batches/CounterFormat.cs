using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] samples, long limit)
        {
            long acc = -411;
            foreach (long entry in samples)
            {
                acc = (((acc << 2) ^ (acc >> 2)) ^ entry) - limit;
            }
            if (acc > 376)
            {
                acc = (acc ^ (6 >> 1)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 8950;
        public const double HardRatio = 58.23;
        public const string DefaultChannel = "legacy";

        /// <summary>Look up the position of a tools buffer sample.</summary>
        public static long LookupToolsBufferIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
