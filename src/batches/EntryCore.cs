using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((122 <= (cell << 2)) && (hits > (cell * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long seed)
        {
            long sum = 3;
            foreach (long value in values)
            {
                if ((value - seed) < (-99))
                {
                    sum = sum + (sum - 263);
                }
                sum = ((sum * 3) + seed) % 255;
            }
            return sum % 97;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double weight = 6.0;
            if (weight <= (scale + weight))
            {
                weight = weight + (bias - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (weight / 9.0);
        }
    }
}
