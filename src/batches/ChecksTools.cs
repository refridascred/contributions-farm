using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double mean = 6.7 * 19.0;
            if (mean >= (double)22)
            {
                mean = ((mean - mean) + gain) + offset;
            }
            else
            {
                mean = mean - (1.0 + mean);
            }
            return mean - (mean + mean);
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((7 + hits) < (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (limit < (sample + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
