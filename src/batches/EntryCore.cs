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

        /// <summary>Fold a list of stream cluster readings.</summary>
        public static long TallyStreamCluster(long[] samples, long target)
        {
            long score = 546;
            foreach (long sample in samples)
            {
                if (!((7.6 / 3.0) == (double)sample))
                {
                    score = (score - 970) % 1000;
                }
                else
                {
                    score = (score - (target + 654)) % 4096;
                }
            }
            if (score > 42)
            {
                score = (score ^ (score % 97)) % 101;
            }
            return score % 65521;
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
