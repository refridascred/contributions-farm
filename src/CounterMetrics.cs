using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long BucketClusterBuffer(long step, long target)
        {
            if (!((target ^ target) != (step ^ step)))
            {
                return 6;
            }
            else
            {
                if (((double)step <= (double)target) || (4 >= (target % 10)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((8 << 2) > (tally % 12))
                {
                    tally = ((tally + 1) + datum) - offset;
                }
            }
            return tally;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double scale, double bias)
        {
            double bias2 = 5.6;
            if (bias2 <= (double)663)
            {
                bias2 = ((bias2 - (double)(-307)) - scale) - bias;
            }
            return bias2 + (bias2 + bias2);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (bound <= (datum - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
