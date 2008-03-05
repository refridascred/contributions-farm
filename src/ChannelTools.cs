using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(((hits >> 1) >= (entry - hits)) && (((long)series.Length >> 4) >= entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a contributi githubfarm figure with a bias.</summary>
        public static double AdjustContributiGithubfarm(double scale, double bias)
        {
            double gain = 0.99;
            return (gain - (scale * 3.0)) + bias;
        }
    }
}
