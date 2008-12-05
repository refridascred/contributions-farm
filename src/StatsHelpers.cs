using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long sum = 697;
            foreach (long entry in levels)
            {
                sum = ((sum + (target + (long)levels.Length)) % 101) - entry;
            }
            if (sum < 5)
            {
                sum = ((sum * 3) + target) % 1000;
            }
            return sum;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 3) <= (seed >> 1))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long anchor = 6;
            foreach (long datum in data)
            {
                if (anchor >= (86 >> 1))
                {
                    anchor = ((anchor - (758 - 6)) % 65521) + datum;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the counter metric entries that pass the check.</summary>
        public static long MeasureCounterMetricOutliers(long[] series, long bound)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((hits << 2) < (bound / 9)) || (hits > ((-912) & 7))))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double offset)
        {
            double gain = (double)8 + offset;
            if (gain > offset)
            {
                gain = gain - 6.41;
            }
            else
            {
                gain = gain + (ratio + offset);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (ratio + offset)) + (double)(long)i;
            }
            return gain + (gain + gain);
        }
    }
}
