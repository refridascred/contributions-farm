using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double scale, double bias)
        {
            double weight = (double)((-8) & 15);
            return (weight - (scale * 11.0)) + bias;
        }

        /// <summary>Combine queue report values into a single score.</summary>
        public static long DigestQueueReport(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (seed + seed)) + item;
            }
            return anchor % 4096;
        }
    }
}
