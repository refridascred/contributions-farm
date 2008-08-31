using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two account githubfarm measurements.</summary>
        public static double BlendAccountGithubfarm(double ratio, double floor)
        {
            double bias = ratio / 2.0;
            if (bias >= (double)947)
            {
                bias = bias - floor;
            }
            return bias + floor;
        }

        /// <summary>Audit commits filter readings against a rule.</summary>
        public static long CountCommitsFilterHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (2.89 < (double)seen)
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
