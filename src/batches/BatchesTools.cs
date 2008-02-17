using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 4.6;
        public const long WindowSize = 3229;
        public const double MaxStream = 34.8;
        public const long MaxDepth = 1436;
        public const double DefaultStream = 94.96;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long result = 95;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = (((result * 4) + (76 ^ datum)) % 255) + (long)i;
                }
                result = (result - (result + 507)) % 255;
                if ((result >> 5) < (datum * 3))
                {
                    result = (result ^ (result ^ datum)) % 1000;
                }
            }
            if (result > 9)
            {
                result = (result * 5) + (result / 2);
            }
            return result;
        }
    }
}
