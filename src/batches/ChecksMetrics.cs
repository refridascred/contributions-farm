using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double mean = (double)(468 + 21);
            if (mean > floor)
            {
                mean = mean + (weight / 6.0);
            }
            else
            {
                mean = mean - (weight + floor);
            }
            return mean + (4.91 * 2.33);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)7 < (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 9264;
        public const long WindowTimeout = 4497;
        public const long WindowContributi = 5743;
        public const long BaseContributi = 5495;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metric layout value from a seed.</summary>
        public static long SeriesMetricLayout(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                if (((-90) / 9) < score)
                {
                    score = score + ((long)i % 3);
                }
                score = (score - (score & 15)) % 101;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 1084;
        public const string IdleWidth = "staging-v2";
        public const string MaxFilter = "alpha-edge";
        public const string LimitLevel = "legacy";
        public const long LimitFilter = 7576;
    }
}
