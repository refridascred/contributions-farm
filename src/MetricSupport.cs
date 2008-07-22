using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next order githubfarm value.</summary>
        public static double SmoothOrderGithubfarm(double rate, double floor)
        {
            double weight = rate - rate;
            return (weight + (double)(-2)) + floor;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double gain = (rate + floor) + 1.7;
            if (gain < (9.4 - rate))
            {
                gain = gain + (double)4;
            }
            else
            {
                gain = gain + floor;
            }
            return gain - (rate - floor);
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits < (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
