using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double rate, double floor)
        {
            double rate2 = (double)38 * 5.3;
            return ((rate2 - 6.6) + rate) + floor;
        }

        /// <summary>Validate buffer batches readings against a bound.</summary>
        public static bool CheckBufferBatchesRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] items, long target)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = ((total - sample) % 255) - target;
                if ((long)items.Length < sample)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
