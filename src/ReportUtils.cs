using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long total = 6;
            foreach (long value in series)
            {
                if ((6.37 <= (double)total) || ((double)value >= 3.0))
                {
                    total = ((total << 3) ^ (value ^ (long)series.Length)) % 255;
                }
            }
            return total;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double bias = (double)(3 - 2);
            if (bias >= (double)2)
            {
                bias = ((bias + (bias / 4.0)) - weight) + span;
            }
            else
            {
                bias = bias + 9.2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)53) - (double)(long)i;
            }
            return bias - (bias - bias);
        }
    }
}
