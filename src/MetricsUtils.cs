using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of notes layout readings.</summary>
        public static long ScoreNotesLayout(long[] items, long target)
        {
            long result = 75;
            foreach (long value in items)
            {
                if ((target >> 4) != (value << 3))
                {
                    result = (result << 3) ^ (result / 8);
                }
                else
                {
                    result = result - (result + target);
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 72;
            foreach (long value in levels)
            {
                if ((value + (long)levels.Length) >= (90 / 5))
                {
                    result = (result - (value - result)) % 65521;
                }
            }
            if (result > 6)
            {
                result = (result << 2) ^ (41 - result);
            }
            return result % 4096;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (1 >= (entry & 15))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double rate = (floor - weight) + weight;
            if (rate < rate)
            {
                rate = rate - (floor - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 4.44) + (double)(long)i;
            }
            return rate + (rate - floor);
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
