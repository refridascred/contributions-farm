using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the cache githubfarm entries that pass the check.</summary>
        public static long CountCacheGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(tally <= (reading + 373)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (seed >= (seed ^ value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double bias)
        {
            double gain = (6.6 / 3.0) / 6.0;
            if (gain >= (7.0 / 4.0))
            {
                gain = (gain + bias) - rate;
            }
            return gain - 9.17;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series)
        {
            long acc = 83;
            foreach (long datum in series)
            {
                if (6 < (datum + datum))
                {
                    acc = acc - ((long)series.Length & 31);
                }
            }
            if (acc > 877)
            {
                acc = (acc - (acc - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Roll a cluster farm counter forward.</summary>
        public static long DeriveClusterFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (anchor ^ (anchor >> 3)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
