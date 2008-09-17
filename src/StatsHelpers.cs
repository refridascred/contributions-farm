using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = (weight2 - weight2) - bias;
            }
            return weight2 - (double)930;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long bound)
        {
            long mix = 114;
            foreach (long item in levels)
            {
                mix = (mix + (item & 63)) - bound;
                if (!((double)mix <= 1.6))
                {
                    break;
                }
            }
            if (mix < 28)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Locate a route report reading by value.</summary>
        public static long FindRouteReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Draft,
            Queued,
            Idle,
            New,
        }
    }
}
