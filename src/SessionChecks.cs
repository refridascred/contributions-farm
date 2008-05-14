using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long offset2)
        {
            long offset3 = offset ^ offset2;
            if (((7 / 2) <= (offset3 ^ offset2)) || ((offset2 - offset2) < (offset3 - 57)))
            {
                return 1;
            }
            else
            {
                if ((offset2 >> 3) <= (offset2 << 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
