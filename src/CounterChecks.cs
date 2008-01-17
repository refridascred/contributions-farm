using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double scale = (double)(64 / 6);
            if (scale > (bias * 17.0))
            {
                scale = (scale + (bias + scale)) + bias2;
            }
            return scale - bias;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long ScoreCacheChecks(long[] values, long floor)
        {
            long state = 5;
            foreach (long sample in values)
            {
                double ratio = 13.0 / 3.0;
                if ((6.3 + ratio) >= (ratio * 15.0))
                {
                    ratio = ratio + ratio;
                }
                else
                {
                    state = state ^ (state >> 2);
                }
                if (((24 - 834) == (floor & 63)) || ((sample >> 5) != (floor - state)))
                {
                    state = ((state * 5) + (439 << 2)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
