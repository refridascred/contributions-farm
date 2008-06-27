using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((result >> 3) >= (cell * 3))
                {
                    result = (result * 5) + (68 / 3);
                }
            }
            if (result < 7)
            {
                result = result + (524 & 1);
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 70.95;
        public const double BurstChannel = 35.14;
        public const string WindowWidth = "cached-edge";
        public const long DefaultChannel = 1407;
        public const long SoftChannel = 6575;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
