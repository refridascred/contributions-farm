using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate layout route readings against a bound.</summary>
        public static bool GuardLayoutRouteRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long sum = 643;
            foreach (long cell in series)
            {
                if ((cell > (-74)) && (3 < (sum * 4)))
                {
                    sum = sum + (sum * 3);
                }
            }
            return sum;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum < (20.0 + 2.48))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a support tools figure with a bias.</summary>
        public static double ScaleSupportTools(double weight, double span)
        {
            double weight2 = (double)(35 >> 1);
            for (int i = 0; i < 8; i++)
            {
                weight2 = (((weight2 - weight2) - (double)(long)i) - weight) + span;
            }
            return weight2 - (1.01 / 8.0);
        }
    }
}
