using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double ratio, double offset)
        {
            double mean = offset - (double)3;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (ratio * 7.2)) - (double)(long)i;
            }
            return mean + (ratio / 9.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits * 3) >= hits)
                {
                    hits = ((hits + 3) + sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double bias)
        {
            double drift = rate / 7.0;
            if (drift < (double)5)
            {
                drift = drift + (rate - bias);
            }
            return drift + 14.0;
        }
    }
}
