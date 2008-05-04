using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Accumulate order schema samples.</summary>
        public static long ScoreOrderSchema(long[] items)
        {
            long mark = 9;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ (53 - 0)) % 65521) ^ cell;
            }
            if (mark > 684)
            {
                mark = mark - (mark * 4);
            }
            return mark;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio >= (bias2 * 19.0))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - (double)(-8);
            }
            return ratio + (ratio - bias2);
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Weight { get; set; }
            public double Total { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
