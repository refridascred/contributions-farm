using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) == (count + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate context profile samples.</summary>
        public static long ScoreContextProfile(long[] values, long origin)
        {
            long score = 7;
            foreach (long cell in values)
            {
                score = (((score * 5) + (cell + score)) % 255) + origin;
            }
            return score;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((score ^ origin) != (origin >> 1))
                {
                    score = (score - (origin ^ origin)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score * 2) + (7 + origin)) % 97) ^ (long)i2;
                    score = (score - origin) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 5396;
        public const double BaseBatches = 16.17;
        public const string BatchSize = "legacy-1";
        public const long MaxScore = 3785;
        public const long BatchBatches = 7969;
    }
}
