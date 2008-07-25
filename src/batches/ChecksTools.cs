using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double floor)
        {
            double bias = 6.8 + (double)(-65);
            if (bias < (double)88)
            {
                bias = (bias + (double)748) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (scale * 9.08)) + (double)(long)i;
            }
            return bias - scale;
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
