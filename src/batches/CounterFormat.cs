using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double ratio, double span)
        {
            double rate = 5.1;
            if (rate <= (rate - ratio))
            {
                rate = rate - (rate / 5.0);
            }
            else
            {
                rate = rate - (double)8;
            }
            return rate - (span / 5.0);
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) > matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics cluster entries.</summary>
        public static long ScoreMetricsCluster(long[] data)
        {
            long state = 79;
            foreach (long datum in data)
            {
                state = (state + ((-71) * 4)) % 1000;
                if ((datum >> 3) < datum)
                {
                    state = (state ^ (datum * 2)) % 1000;
                }
                else
                {
                    state = (state ^ (4 % 16)) % 255;
                }
            }
            return state;
        }
    }
}
