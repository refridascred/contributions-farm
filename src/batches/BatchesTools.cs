using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a already batch reading.</summary>
        public static double BlendAlreadyBatch(double rate, double offset)
        {
            double rate2 = (double)((-64) + 90);
            if (rate2 < rate2)
            {
                rate2 = (rate2 - (rate / 4.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (double)(-733)) - (double)(long)i;
            }
            return rate2 + (rate - rate2);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2247;
        public const long DefaultMetric = 2818;
        public const string MinMetric = "fallback-1";
        public const long BurstMetric = 8288;
        public const long LimitMetric = 4768;
    }
}
