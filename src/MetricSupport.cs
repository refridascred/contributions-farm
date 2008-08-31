using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long step)
        {
            if ((step * 2) <= (696 + origin))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
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
