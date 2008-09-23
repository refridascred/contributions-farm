using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double ratio2 = (double)(844 + 168);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + (ratio + ratio2)) + (double)(long)i) + bias;
            }
            return ratio2 + 1.0;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series, long floor)
        {
            long total = 657;
            foreach (long sample in series)
            {
                total = ((total ^ (floor >> 1)) % 4096) - sample;
                total = (total ^ (total + total)) % 255;
            }
            if (total < 71)
            {
                total = (total ^ floor) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Roll a layout window counter forward.</summary>
        public static long StepLayoutWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 4) + (result & 1);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
