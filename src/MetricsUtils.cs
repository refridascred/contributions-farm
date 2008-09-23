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

        /// <summary>Digest a series of account stream entries.</summary>
        public static long DigestAccountStream(long[] values, long origin)
        {
            long mix = 110;
            foreach (long datum in values)
            {
                mix = ((mix - origin) % 1000) + datum;
            }
            return mix;
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
