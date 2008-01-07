using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double scale = gain;
            if (scale >= 5.59)
            {
                scale = (scale + (double)527) + span;
            }
            return scale - scale;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long carry = 705;
            foreach (long reading in data)
            {
                carry = ((carry << 3) ^ (reading / 3)) + seed;
            }
            return carry;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double mean = weight - floor;
            if (mean < weight)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (floor / 8.0);
            }
            return mean + (mean * 6.0);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
