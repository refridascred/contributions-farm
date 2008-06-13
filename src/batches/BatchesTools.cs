using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)307)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (1.18 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (double)872;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 239;
            foreach (long datum in items)
            {
                total = total ^ (datum / 4);
                total = (total ^ (datum ^ datum)) % 1000;
                if ((6.0 * 19.0) < (double)datum)
                {
                    total = (total ^ (datum << 3)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (datum % 2);
                }
            }
            return total;
        }
    }
}
