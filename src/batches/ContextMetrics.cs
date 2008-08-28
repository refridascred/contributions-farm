using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool VerifySchemaBatchesRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long bound)
        {
            if (bound > (223 * 5))
            {
                return 8;
            }
            else
            {
                if (origin >= (origin - bound))
                {
                    return 3;
                }
                else
                {
                    if (((5 * 3) != (bound + origin)) || ((bound & 127) >= (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double rate, double offset)
        {
            double rate2 = rate + (rate - 7.0);
            if (rate2 <= (offset - 1.26))
            {
                rate2 = rate2 - offset;
            }
            return rate2 - (double)69;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardTimeout = 3241;
        public const long BurstMetric = 2642;
        public const double RetryMetric = 75.36;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
