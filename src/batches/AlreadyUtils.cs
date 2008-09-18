using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long ScoreCacheMetrics(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if ((entry + entry) > state)
                {
                    state = (state << 3) ^ (entry % 2);
                }
                else
                {
                    state = ((state * 5) + (65 & 15)) % 65521;
                }
                if (entry > 87)
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a contributi record reading.</summary>
        public static double BlendContributiRecord(double rate, double span)
        {
            double ratio = (double)(17 << 2);
            if (ratio >= ratio)
            {
                ratio = ((ratio - (ratio / 2.0)) + rate) - span;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
