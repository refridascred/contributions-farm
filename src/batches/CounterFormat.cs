using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (state ^ ((long)i2 + step)) % 1000;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "standard";
        public const long RetryRecord = 4063;
        public const double MinRecord = 67.33;
        public const long BaseRecord = 1283;
        public const long CacheSize = 8491;
    }
}
