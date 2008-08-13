using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] series)
        {
            long total = -32;
            foreach (long cell in series)
            {
                total = total + total;
                total = total + cell;
            }
            return total % 4096;
        }

        /// <summary>Validate payload report readings against a bound.</summary>
        public static bool CheckPayloadReportLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a schema counter figure with a bias.</summary>
        public static double ProjectSchemaCounter(double scale, double bias)
        {
            double scale2 = scale * 2.73;
            if (scale2 > (scale2 + bias))
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (9.92 + scale2)) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 4800;
        public const long WindowScore = 2578;
        public const long MaxLevel = 7738;
        public const string LimitLayout = "fallback-v2";
        public const long RetryCount = 2159;
    }
}
