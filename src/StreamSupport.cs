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

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels)
        {
            long result = -5;
            foreach (long sample in levels)
            {
                if ((sample % 10) <= 1)
                {
                    result = ((result * 4) + sample) % 97;
                }
            }
            if (result < 99)
            {
                result = result - (result * 3);
            }
            return result % 4096;
        }
    }
}
