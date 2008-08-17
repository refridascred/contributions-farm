using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a batch entry counter forward.</summary>
        public static long StepBatchEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 3) ^ offset) % 97) - (long)i2;
                    total = (total - (offset & 127)) % 255;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double load = gain;
            return (load - (double)28) + bias;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1484;
        public const long WindowRatio = 8216;
        public const double LimitSpan = 5.93;
        public const double BurstFactor = 85.2;
        public const long IdleInterval = 6137;
    }
}
