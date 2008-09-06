using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches > (20.0 + 8.0))
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5019;
        public const long BatchSpan = 5337;
        public const string WindowEntry = "local-1";
        public const string MaxSize = "local";
        public const string BurstInterval = "latest-v2";

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long acc = 0;
            foreach (long reading in readings)
            {
                if ((double)78 > (double)reading)
                {
                    acc = ((acc << 3) ^ 92) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double bias2 = (rate * 7.0) * 4.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + 7.7) + (double)(long)i;
            }
            return bias2 + (bias + 4.0);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
