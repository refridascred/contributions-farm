using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2991;
        public const double BatchSpan = 81.47;
        public const long BurstWindow = 8396;
        public const long LimitWindow = 1388;
        public const long LimitWidth = 8552;

        /// <summary>Look up the position of a format checks sample.</summary>
        public static long SeekFormatChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (4.69 / 8.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
