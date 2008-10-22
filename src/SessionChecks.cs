using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxLevel = 2618;
        public const long SoftEntry = 4847;
        public const string WindowInterval = "staging-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6254;
        public const long BatchFilter = 9772;
        public const string HardBudget = "open-edge";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total + ((-535) + limit)) % 101) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
