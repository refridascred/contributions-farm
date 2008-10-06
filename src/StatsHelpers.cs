using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double ratio, double offset)
        {
            double gain = (offset - offset) * 7.5;
            return (gain - 14.0) + ratio;
        }

        /// <summary>Validate cache contributi readings against a bound.</summary>
        public static bool GuardCacheContributiBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items, long limit)
        {
            long mix = 933;
            foreach (long reading in items)
            {
                mix = (mix + limit) % 97;
                if (mix < (mix * 3))
                {
                    mix = (mix * 3) + (reading << 1);
                }
                mix = (mix + (reading / 6)) % 97;
            }
            if (mix < 0)
            {
                mix = (mix << 2) ^ (-58);
            }
            return mix;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
