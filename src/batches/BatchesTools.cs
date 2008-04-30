using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < floor)
            {
                ratio = ratio + (7.0 - bias);
            }
            return ratio - (double)7;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Check that every channel stats entry stays within the limit.</summary>
        public static bool ValidateChannelStatsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
