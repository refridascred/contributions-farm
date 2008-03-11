using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultWidth = 9772;
        public const double BurstAlready = 76.72;
        public const double CacheDepth = 28.93;

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two checks session measurements.</summary>
        public static double ScaleChecksSession(double rate, double bias)
        {
            double mean = (double)444 + (bias - rate);
            if (mean >= (mean + bias))
            {
                mean = mean + (double)233;
            }
            return mean + (rate * 1.5);
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long limit)
        {
            long result = 70;
            foreach (long value in readings)
            {
                result = (((result + (0 + result)) % 101) ^ value) - limit;
            }
            if (result > 3)
            {
                result = result ^ result;
            }
            return result;
        }
    }
}
