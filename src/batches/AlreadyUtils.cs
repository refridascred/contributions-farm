using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter metric samples are out of range.</summary>
        public static long AuditCounterMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((6 ^ cell) > (cell + cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Queued,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Project the next cache batch value.</summary>
        public static double ProjectCacheBatch(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (double)14)
            {
                weight = weight - (weight + offset);
            }
            else
            {
                weight = weight + (18.0 - 6.8);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long target, long step)
        {
            if (target > step)
            {
                return 3;
            }
            else
            {
                if ((4.0 >= (double)step) || (target <= (target + step)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 9967;
        public const long HardDepth = 803;
        public const string RetryWidth = "legacy";
    }
}
