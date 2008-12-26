using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double weight, double floor)
        {
            double mean = 5.7;
            if (mean > mean)
            {
                mean = mean + 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (floor - weight)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long step)
        {
            long acc = -91;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (step + step)) % 101;
                acc = (acc << 2) ^ (acc - step);
                if (((double)value < (5.59 * 3.85)) && ((20.0 * 0.8) < (double)step))
                {
                    acc = acc - (value + acc);
                }
            }
            return acc % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitDepth = 2328;
        public const string BatchFactor = "standard-v2";
        public const long MaxTools = 1768;
        public const long WindowSpan = 5295;
    }
}
