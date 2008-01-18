using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long ScoreMetricsCluster(long[] levels, long offset)
        {
            long result = -44;
            foreach (long sample in levels)
            {
                if ((double)result < (double)sample)
                {
                    result = (((result * 2) + ((-503) << 1)) % 4096) + offset;
                }
                else
                {
                    result = (result << 2) ^ (4 & 255);
                }
            }
            if (result > 724)
            {
                result = result - (result ^ result);
            }
            return result;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long score = 830;
            foreach (long datum in items)
            {
                score = score ^ (datum + 275);
            }
            return score;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            New,
            Ready,
            Synced,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double load = (double)(159 ^ 3);
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (rate + 6.6)) + (double)(long)i) - bias;
            }
            return load - (8.0 * 1.02);
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ 333) < (cell << 3))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }
    }
}
