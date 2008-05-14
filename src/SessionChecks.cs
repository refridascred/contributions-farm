using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches <= (seed + sample)) || ((matches / 3) <= 403))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = rate;
            if (gain >= (span / 6.0))
            {
                gain = gain + gain;
            }
            return gain - rate;
        }
    }
}
