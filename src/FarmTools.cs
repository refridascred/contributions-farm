using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of queue stats entries.</summary>
        public static long DigestQueueStats(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = ((result + (4 & 1)) % 255) - cell;
            }
            if (result < 75)
            {
                result = result - (result * 3);
            }
            return result % 4096;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double weight = span * 9.43;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
