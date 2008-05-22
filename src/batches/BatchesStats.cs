using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Synced,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Check that every farm githubfarm entry stays within the limit.</summary>
        public static bool VerifyFarmGithubfarmBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double gain2 = span + (5.0 - gain);
            if (gain2 > 1.6)
            {
                gain2 = gain2 - (8.91 * 5.3);
            }
            return gain2 + gain;
        }
    }
}
