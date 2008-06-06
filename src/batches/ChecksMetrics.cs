using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (step > ((long)i - 181))
                {
                    total = ((total * 4) + (step ^ step)) % 65521;
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit metrics notes readings against a rule.</summary>
        public static long MeasureMetricsNotesHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((limit ^ 20) < (907 / 4))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double floor)
        {
            double mean = (floor * 0.21) / 8.0;
            if (mean > mean)
            {
                mean = mean - (rate - rate);
            }
            return mean + 7.66;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long floor)
        {
            long lane = step - floor;
            if ((floor % 7) < lane)
            {
                return 0;
            }
            else
            {
                if (floor <= (step + lane))
                {
                    return 4;
                }
                else
                {
                    if (!((lane - step) == (step >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 62.34;
        public const long BurstLevel = 6621;
        public const long CacheBudget = 2818;
        public const long BurstInterval = 2530;
        public const long BatchWidth = 4184;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((627 + hits) < step)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
