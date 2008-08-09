using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every counter metric entry stays within the limit.</summary>
        public static bool GuardCounterMetricBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long seed)
        {
            if ((double)limit <= (8.17 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((9.7 - 13.0) < (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double weight = 7.03;
            if (weight > 0.1)
            {
                weight = (weight - (weight - weight)) - ratio;
            }
            else
            {
                weight = weight - (bias - 0.1);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (double)14) - (double)(long)i;
            }
            return weight + (double)612;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Stale,
            Pending,
            Idle,
            Draft,
        }
    }
}
