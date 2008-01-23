using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a channel route figure with a bias.</summary>
        public static double ScaleChannelRoute(double ratio, double offset)
        {
            double mean = (double)(735 ^ 81);
            if (mean <= offset)
            {
                mean = (mean + 13.0) - ratio;
            }
            else
            {
                mean = mean + (double)37;
            }
            return mean - (offset * 1.0);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Ready,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
