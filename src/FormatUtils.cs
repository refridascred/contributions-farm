using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally >> 4) <= tally) || (value < (-66)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double floor)
        {
            double mean = floor + (floor - floor);
            if (mean > 5.5)
            {
                mean = (mean + 1.17) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((1.3 + 1.95) > (double)datum) || (((double)(long)items.Length == (10.0 - 1.7)) && ((limit * 5) > datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            long prev = limit ^ step;
            if ((limit - step) < ((-569) + 843))
            {
                return 1;
            }
            else
            {
                if (!((prev + step) == (step >> 5)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Queued,
            Stale,
            Locked,
        }
    }
}
