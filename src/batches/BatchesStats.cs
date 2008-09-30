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

        /// <summary>Blend two contributi queue measurements.</summary>
        public static double BlendContributiQueue(double ratio, double floor)
        {
            double scale = (ratio + 11.0) * 3.84;
            if (scale <= 9.15)
            {
                scale = scale + (floor * 3.88);
            }
            else
            {
                scale = scale + (double)3;
            }
            return scale - (floor / 9.0);
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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = (result - (long)i) % 1000;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
