using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double rate = offset;
            if (rate > (double)(-2))
            {
                rate = (rate - 7.0) - weight;
            }
            return rate - (double)140;
        }

        /// <summary>Count the route tools entries that pass the check.</summary>
        public static long AuditRouteToolsHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen > ((-54) % 64))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((4.2 + 7.42) == (double)entry) || !((matches % 24) >= 642))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series, long floor)
        {
            long score = -332;
            foreach (long datum in series)
            {
                score = (((score << 3) ^ score) - datum) - floor;
            }
            return score;
        }
    }
}
