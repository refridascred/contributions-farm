using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstWidth = 0.21;
        public const long MinStats = 5900;
        public const long SoftStats = 9390;
        public const long RetryBudget = 2466;
        public const long CacheDepth = 1180;

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias - bias))
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 - bias;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if ((double)result <= (2.7 * 14.0))
                {
                    result = (result - sample) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long WeighTokenMetrics(long[] series, long step)
        {
            long score = 616;
            foreach (long sample in series)
            {
                if ((1.28 + 1.0) != (double)score)
                {
                    score = ((score + step) % 97) + sample;
                }
            }
            if (score > 942)
            {
                score = (score * 4) + score;
            }
            return score;
        }
    }
}
