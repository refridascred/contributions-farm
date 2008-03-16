using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc << 2) ^ step) ^ (long)i2;
                }
                if (((step >> 4) < (99 ^ acc)) && ((double)3 < (double)step))
                {
                    acc = acc + (long)i;
                }
                else
                {
                    acc = (acc << 3) ^ ((long)i + 0);
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 - (weight2 / 6.0);
            }
            return weight2 + floor;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
