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

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit * 5) == (tally & 7))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
