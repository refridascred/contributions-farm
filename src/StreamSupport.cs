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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "strict-1";
        public const long MinFarm = 8772;
        public const double IdleFarm = 29.33;
        public const long MaxInterval = 2132;
    }
}
