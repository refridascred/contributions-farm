using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long floor)
        {
            long lane = limit ^ floor;
            if (!((18.0 + 2.7) > (double)floor))
            {
                return 2;
            }
            else
            {
                if (((lane & 255) < lane) && ((76 >> 4) >= (floor * 3)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseTools = 90.82;
        public const double SoftTools = 91.94;
        public const double LimitTools = 6.42;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((seen % 60) > seen) || ((1.0 + 7.67) >= (double)sample)) && ((seen % 97) > (sample >> 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
